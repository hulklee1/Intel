#pragma once
#include <afxdialogex.h>
class CmfcFindDlg : public CDialogEx
{
public:
    CString mStr;

    CmfcFindDlg();

    // 대화 상자 데이터입니다.
#ifdef AFX_DESIGN_TIME
    enum { IDD = IDD_FIND_DIALOG };
#endif
    virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 지원입니다.

    afx_msg void OnKeyDown(UINT nChar, UINT nRepCnt, UINT nFlags);
    virtual BOOL OnInitDialog();

    DECLARE_MESSAGE_MAP()
    virtual BOOL PreTranslateMessage(MSG* pMsg);
    afx_msg void OnEnChangeEditFind();
};

