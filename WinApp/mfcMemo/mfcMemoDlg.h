﻿
// mfcMemoDlg.h: 헤더 파일
//

#pragma once


// CmfcMemoDlg 대화 상자
class CmfcMemoDlg : public CDialogEx
{
	CString sFind;
	int pos = 0;
	int mEncoding = 0;  // 0:ANSI  1:UTF-8

// 생성입니다.
public:
	CmfcMemoDlg(CWnd* pParent = nullptr);	// 표준 생성자입니다.

// 대화 상자 데이터입니다.
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_MFCMEMO_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 지원입니다.

// 구현입니다.
protected:
	HICON m_hIcon;
	HACCEL mAccel;
	// 생성된 메시지 맵 함수
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnMenuOpen();
	afx_msg void OnMenuSelect(UINT nItemID, UINT nFlags, HMENU hSysMenu);
	afx_msg void OnMenuAbout();
	afx_msg void OnMenuFind();
	void AddText(CString s);
	CEdit mEditMemo;
	afx_msg void OnMenuNext();
	virtual BOOL PreTranslateMessage(MSG* pMsg);
	afx_msg void OnMenuUtf8();
	afx_msg void OnMenuAnsi();
};
