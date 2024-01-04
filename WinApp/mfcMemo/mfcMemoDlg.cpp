
// mfcMemoDlg.cpp: 구현 파일
//

#include "pch.h"
#include "framework.h"
#include "mfcMemo.h"
#include "mfcMemoDlg.h"
#include "CmfcFindDlg.h"
#include "afxdialogex.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

#include <cstring>
#include <iostream>
#include <fstream>

// 응용 프로그램 정보에 사용되는 CAboutDlg 대화 상자입니다.

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// 대화 상자 데이터입니다.
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_ABOUTBOX };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 지원입니다.

// 구현입니다.
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(IDD_ABOUTBOX)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CmfcMemoDlg 대화 상자



CmfcMemoDlg::CmfcMemoDlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_MFCMEMO_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CmfcMemoDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_EDIT_MEMO, mEditMemo);
}

BEGIN_MESSAGE_MAP(CmfcMemoDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_COMMAND(ID_MENU_OPEN, &CmfcMemoDlg::OnMenuOpen)
	ON_WM_MENUSELECT()
	ON_COMMAND(ID_MENU_ABOUT, &CmfcMemoDlg::OnMenuAbout)
	ON_COMMAND(ID_MENU_FIND, &CmfcMemoDlg::OnMenuFind)
	ON_COMMAND(ID_MENU_NEXT, &CmfcMemoDlg::OnMenuNext)
	ON_COMMAND(ID_MENU_UTF8, &CmfcMemoDlg::OnMenuUtf8)
	ON_COMMAND(ID_MENU_ANSI, &CmfcMemoDlg::OnMenuAnsi)
END_MESSAGE_MAP()


// CmfcMemoDlg 메시지 처리기

BOOL CmfcMemoDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// 시스템 메뉴에 "정보..." 메뉴 항목을 추가합니다.

	// IDM_ABOUTBOX는 시스템 명령 범위에 있어야 합니다.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != nullptr)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// 이 대화 상자의 아이콘을 설정합니다.  응용 프로그램의 주 창이 대화 상자가 아닐 경우에는
	//  프레임워크가 이 작업을 자동으로 수행합니다.
	SetIcon(m_hIcon, TRUE);			// 큰 아이콘을 설정합니다.
	SetIcon(m_hIcon, FALSE);		// 작은 아이콘을 설정합니다.

	// TODO: 여기에 추가 초기화 작업을 추가합니다.
	mAccel = LoadAccelerators(AfxGetInstanceHandle(), MAKEINTRESOURCE(IDR_ACCEL1));

	return TRUE;  // 포커스를 컨트롤에 설정하지 않으면 TRUE를 반환합니다.
}

void CmfcMemoDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// 대화 상자에 최소화 단추를 추가할 경우 아이콘을 그리려면
//  아래 코드가 필요합니다.  문서/뷰 모델을 사용하는 MFC 애플리케이션의 경우에는
//  프레임워크에서 이 작업을 자동으로 수행합니다.

void CmfcMemoDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // 그리기를 위한 디바이스 컨텍스트입니다.

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// 클라이언트 사각형에서 아이콘을 가운데에 맞춥니다.
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// 아이콘을 그립니다.
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// 사용자가 최소화된 창을 끄는 동안에 커서가 표시되도록 시스템에서
//  이 함수를 호출합니다.
HCURSOR CmfcMemoDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CmfcMemoDlg::OnMenuOpen()	// File Open Menu 처리기
{
	char buf[512];
	CString str;

	char fName[100];  // ofn 의 filename 저장공간
	OPENFILENAME ofn;
	ZeroMemory(&ofn, sizeof(ofn));	// 메모리 공간 청소
	ZeroMemory(fName, sizeof(fName));

	ofn.lStructSize = sizeof(OPENFILENAME);
	ofn.lpstrFile = fName;
	ofn.nMaxFile = 100;
	ofn.lpstrDefExt = "";
	if (!GetOpenFileName(&ofn)) return;

	str = buf;  // CString <== WCHAR,  CString <== char
		
	if (mEncoding == 0) // C 언어의 표준함수. ANSI encoding
	{
		FILE* fp = fopen(fName, "rb");	
		while (fgets(buf, 512, fp))
		{
			((CEdit*)GetDlgItem(IDC_EDIT1))->GetWindowText(str);
			GetDlgItem(IDC_EDIT1)->SetWindowText(str + buf);
		}
	}	
	else if (mEncoding == 1) // C++ stream 표준 .UTF-8 encoding
	{
		wchar_t buf1[512];
		std::locale::global(std::locale(".UTF-8"));
		std::wifstream ff(fName);
		for (; ff.getline(buf1, 512);)
		{
			str = buf1;
			AddText(str); AddText("\r\n");
		}
	}
}

void CmfcMemoDlg::AddText(CString s)
{
	CString str;
	((CEdit*)GetDlgItem(IDC_EDIT1))->GetWindowText(str);
	str += s;
	GetDlgItem(IDC_EDIT1)->SetWindowText(str);
}

void CmfcMemoDlg::OnMenuSelect(UINT nItemID, UINT nFlags, HMENU hSysMenu)
{
	CDialogEx::OnMenuSelect(nItemID, nFlags, hSysMenu);

	// TODO: 여기에 메시지 처리기 코드를 추가합니다.
}

void CmfcMemoDlg::OnMenuAbout()
{
	CAboutDlg dlg;
	dlg.DoModal();
}

void CmfcMemoDlg::OnMenuFind()
{
	CmfcFindDlg dlg;
	if (dlg.DoModal() == IDOK) // FIND 할 문자열 입력
	{
		CString s;
		mEditMemo.GetWindowText(s);
		sFind = dlg.mStr;
		int start = s.Find(dlg.mStr);
		int end = start + dlg.mStr.GetLength();
		mEditMemo.SetSel(start, end);
		pos = start + 1;
	}
}

void CmfcMemoDlg::OnMenuNext()
{
	CString s;
	mEditMemo.GetWindowText(s);
	int start = s.Find(sFind, pos);
	int end = start + sFind.GetLength();
	mEditMemo.SetSel(start, end);
	pos = start + 1;
}


BOOL CmfcMemoDlg::PreTranslateMessage(MSG* pMsg)
{
	// TODO: 여기에 특수화된 코드를 추가 및/또는 기본 클래스를 호출합니다.
	if (mAccel)
	{
		if (TranslateAccelerator(m_hWnd, mAccel, pMsg))	return TRUE;
	}
	return CDialogEx::PreTranslateMessage(pMsg);
}


void CmfcMemoDlg::OnMenuUtf8()
{
	CMenu* m = GetMenu();
	m->CheckMenuItem(ID_MENU_UTF8, MF_CHECKED);
	m->CheckMenuItem(ID_MENU_ANSI, MF_UNCHECKED);
	mEncoding = 1;
}


void CmfcMemoDlg::OnMenuAnsi()
{
	CMenu* m = GetMenu();
	m->CheckMenuItem(ID_MENU_UTF8, MF_UNCHECKED);
	m->CheckMenuItem(ID_MENU_ANSI, MF_CHECKED);
	mEncoding = 0;
}
