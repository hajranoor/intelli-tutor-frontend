/*
  winsnmp.h - Header file for the Windows SNMP API

  Written by Filip Navara <xnavara@volny.cz>

  References (2003-08-25):
    Windows SNMP
    http://www.winsnmp.com/docs/winsnmp.doc

    WinSNMP v2.0 Addendum
    http://www.winsnmp.com/docs/winsnmp2.txt

    WinSNMP v3.0 API Addendum
    http://www.winsnmp.com/docs/winsnmp3.htm

    WinSNMP Reference
    http://msdn.microsoft.com/library/en-us/snmp/snmp/winsnmp_api_reference.asp

  This library is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
*/

#ifndef _WINSNMP_H
#define _WINSNMP_H
#if __GNUC__ >= 3
#pragma GCC system_header
#endif

#ifndef _WINDOWS_H
#include <windows.h>
#endif

#include <pshpack4.h>

#ifndef WINSNMPAPI
#define WINSNMPAPI WINAPI
#endif

#ifdef __cplusplus
extern "C" {
#endif

#define MAXOBJIDSIZE	128
#define MAXOBJIDSTRSIZE	1408
#define MAXVENDORINFO	32
#ifndef _SNMP_ASN_DEFINED
#define _SNMP_ASN_DEFINED
#define ASN_UNIVERSAL	0x00
#define ASN_PRIMITIVE	0x00
#define ASN_CONSTRUCTOR	0x20
#define ASN_APPLICATION	0x40
#define ASN_CONTEXT	0x80
#define ASN_PRIVATE	0xC0
#define SNMP_PDU_GET	(ASN_CONTEXT | ASN_CONSTRUCTOR | 0)
#define SNMP_PDU_GETNEXT	(ASN_CONTEXT | ASN_CONSTRUCTOR | 1)
#define SNMP_PDU_RESPONSE	(ASN_CONTEXT | ASN_CONSTRUCTOR | 2)
#define SNMP_PDU_SET	(ASN_CONTEXT | ASN_CONSTRUCTOR | 3)
#define SNMP_PDU_GETBULK	(ASN_CONTEXT | ASN_CONSTRUCTOR | 4)
#define SNMP_PDU_V1TRAP	(ASN_CONTEXT | ASN_CONSTRUCTOR | 4)
#define SNMP_PDU_INFORM	(ASN_CONTEXT | ASN_CONSTRUCTOR | 6)
#define SNMP_PDU_TRAP	(ASN_CONTEXT | ASN_CONSTRUCTOR | 7)
#define SNMP_PDU_REPORT	(ASN_CONTEXT | ASN_CONSTRUCTOR | 8)
#endif /* _SNMP_ASN_DEFINED */
#define SNMP_SYNTAX_SEQUENCE	(ASN_UNIVERSAL | ASN_CONSTRUCTOR | 0x10)
#define SNMP_SYNTAX_INT	(ASN_UNIVERSAL | ASN_PRIMITIVE | 0x02)
#define SNMP_SYNTAX_BITS	(ASN_UNIVERSAL | ASN_PRIMITIVE | 0x03)
#define SNMP_SYNTAX_OCTETS	(ASN_UNIVERSAL | ASN_PRIMITIVE | 0x04)
#define SNMP_SYNTAX_NULL	(ASN_UNIVERSAL | ASN_PRIMITIVE | 0x05)
#define SNMP_SYNTAX_OID	(ASN_UNIVERSAL | ASN_PRIMITIVE | 0x06)
#define SNMP_SYNTAX_IPADDR	(ASN_APPLICATION | ASN_PRIMITIVE | 0x00)
#define SNMP_SYNTAX_CNTR32	(ASN_APPLICATION | ASN_PRIMITIVE | 0x01)
#define SNMP_SYNTAX_GAUGE32	(ASN_APPLICATION | ASN_PRIMITIVE | 0x02)
#define SNMP_SYNTAX_TIMETICKS	(ASN_APPLICATION | ASN_PRIMITIVE | 0x03)
#define SNMP_SYNTAX_OPAQUE	(ASN_APPLICATION | ASN_PRIMITIVE | 0x04)
#define SNMP_SYNTAX_NSAPADDR	(ASN_APPLICATION | ASN_PRIMITIVE | 0x05)
#define SNMP_SYNTAX_CNTR64	(ASN_APPLICATION | ASN_PRIMITIVE | 0x06)
#define SNMP_SYNTAX_UINT32	(ASN_APPLICATION | ASN_PRIMITIVE | 0x07)
#define SNMP_SYNTAX_NOSUCHOBJECT	(ASN_CONTEXT | ASN_PRIMITIVE | 0x00)
#define SNMP_SYNTAX_NOSUCHINSTANCE	(ASN_CONTEXT | ASN_PRIMITIVE | 0x01)
#define SNMP_SYNTAX_ENDOFMIBVIEW	(ASN_CONTEXT | ASN_PRIMITIVE | 0x02)
#define SNMP_SYNTAX_INT32	SNMP_SYNTAX_INT
#define SNMP_TRAP_COLDSTART	0
#define SNMP_TRAP_WARMSTART	1
#define SNMP_TRAP_LINKDOWN	2
#define SNMP_TRAP_LINKUP	3
#define SNMP_TRAP_AUTHFAIL	4
#define SNMP_TRAP_EGPNEIGHBORLOSS	5
#define SNMP_TRAP_ENTERPRISESPECIFIC	6
#define SNMP_ERROR_NOERROR	0
#define SNMP_ERROR_TOOBIG	1
#define SNMP_ERROR_NOSUCHNAME	2
#define SNMP_ERROR_BADVALUE	3
#define SNMP_ERROR_READONLY	4
#define SNMP_ERROR_GENERR	5
#define SNMP_ERROR_NOACCESS	6
#define SNMP_ERROR_WRONGTYPE	7
#define SNMP_ERROR_WRONGLENGTH	8
#define SNMP_ERROR_WRONGENCODING	9
#define SNMP_ERROR_WRONGVALUE	10
#define SNMP_ERROR_NOCREATION	11
#define SNMP_ERROR_INCONSISTENTVALUE	12
#define SNMP_ERROR_RESOURCEUNAVAILABLE	13
#define SNMP_ERROR_COMMITFAILED	14
#define SNMP_ERROR_UNDOFAILED	15
#define SNMP_ERROR_AUTHORIZATIONERROR	16
#define SNMP_ERROR_NOTWRITABLE	17
#define SNMP_ERROR_INCONSISTENTNAME	18
#define SNMP_SEC_MODEL_V1	1
#define SNMP_SEC_MODEL_V2	2
#define SNMP_SEC_MODEL_USM	3
#define SNMP_NOAUTH_NOPRIV	0
#define SNMP_AUTH_NOPRIV	1
#define SNMP_AUTH_PRIV	3
#define SNMP_USM_NO_AUTH_PROTOCOL	1
#define SNMP_USM_HMACMD5_AUTH_PROTOCOL	2
#define SNMP_USM_HMACSHA_AUTH_PROTOCOL	3
#define SNMP_USM_NO_PRIV_PROTOCOL	1
#define SNMP_USM_DES_PRIV_PROTOCOL	2
#define SNMPAPI_TRANSLATED	0
#define SNMPAPI_UNTRANSLATED_V1	1
#define SNMPAPI_UNTRANSLATED_V2	2
#define SNMPAPI_UNTRANSLATED_V3	3
#define SNMPAPI_OFF 0
#define SNMPAPI_ON 1
#define SNMPAPI_FAILURE 0
#define SNMPAPI_SUCCESS 1
#define SNMPAPI_NO_SUPPORT	0
#define SNMPAPI_V1_SUPPORT	1
#define SNMPAPI_V2_SUPPORT	2
#define SNMPAPI_M2M_SUPPORT	3
#define SNMPAPI_V3_SUPPORT	3
#define SNMPAPI_ALLOC_ERROR	2
#define SNMPAPI_CONTEXT_INVALID	3
#define SNMPAPI_CONTEXT_UNKNOWN	4
#define SNMPAPI_ENTITY_INVALID	5
#define SNMPAPI_ENTITY_UNKNOWN	6
#define SNMPAPI_INDEX_INVALID	7
#define SNMPAPI_NOOP	8
#define SNMPAPI_OID_INVALID	9
#define SNMPAPI_OPERATION_INVALID	10
#define SNMPAPI_OUTPUT_TRUNCATED	11
#define SNMPAPI_PDU_INVALID	12
#define SNMPAPI_SESSION_INVALID	13
#define SNMPAPI_SYNTAX_INVALID	14
#define SNMPAPI_VBL_INVALID	15
#define SNMPAPI_MODE_INVALID	16
#define SNMPAPI_SIZE_INVALID	17
#define SNMPAPI_NOT_INITIALIZED	18
#define SNMPAPI_MESSAGE_INVALID	19
#define SNMPAPI_HWND_INVALID	20
#define SNMPAPI_ENGINE_INVALID	30
#define SNMPAPI_ENGINE_DISCOVERY_FAILED	31
#define SNMPAPI_OTHER_ERROR	99
#define SNMPAPI_TL_NOT_INITIALIZED	100
#define SNMPAPI_TL_NOT_SUPPORTED	101
#define SNMPAPI_TL_NOT_AVAILABLE	102
#define SNMPAPI_TL_RESOURCE_ERROR	103
#define SNMPAPI_TL_UNDELIVERABLE	104
#define SNMPAPI_TL_SRC_INVALID	105
#define SNMPAPI_TL_INVALID_PARAM	106
#define SNMPAPI_TL_IN_USE	107
#define SNMPAPI_TL_TIMEOUT	108
#define SNMPAPI_TL_PDU_TOO_BIG	109
#define SNMPAPI_TL_OTHER	199
#define SNMPAPI_RPT_INVALIDMSG	200
#define SNMPAPI_RPT_INASNPARSEERR	201
#define SNMPAPI_RPT_UNKNOWNSECMODEL	202
#define SNMPAPI_RPT_UNKNOWNENGINEID	203
#define SNMPAPI_RPT_UNSUPPSECLEVEL	204
#define SNMPAPI_RPT_UNKNOWNUSERNAME	205
#define SNMPAPI_RPT_WRONGDIGEST	206
#define SNMPAPI_RPT_NOTINTIMEWINDOW	207
#define SNMPAPI_RPT_DECRYPTIONERROR	208
#define SNMPAPI_RPT_OTHER	299

#ifndef RC_INVOKED

typedef HANDLE HSNMP_SESSION, *LPHSNMP_SESSION;
typedef HANDLE HSNMP_CONTEXT, *LPHSNMP_CONTEXT;
typedef HANDLE HSNMP_VBL, *LPHSNMP_VBL;
typedef HANDLE HSNMP_PDU, *LPHSNMP_PDU;
typedef HANDLE HSNMP_ENTITY, *LPHSNMP_ENTITY;
typedef unsigned char smiBYTE, *smiLPBYTE;
typedef signed int smiINT, *smiLPINT;
typedef signed int smiINT32, *smiLPINT32;
typedef unsigned int smiUINT32, *smiLPUINT32;
typedef smiUINT32 smiCNTR32, *smiLPCNTR32;
typedef smiUINT32 smiGAUGE32, *smiLPGAUGE32;
typedef smiUINT32 smiTIMETICKS, *smiLPTIMETICKS;
typedef smiUINT32 SNMPAPI_STATUS;
typedef struct {
	smiUINT32 len;
	smiLPBYTE ptr;
} smiOCTETS, *smiLPOCTETS, smiOPAQUE, *smiLPOPAQUE, smiBITS, *smiLPBITS, smiIPADDR, *smiLPIPADDR, smiNSAPADDR, *smiLPNSAPADDR;
typedef const smiLPOCTETS smiLPCOCTETS;
typedef struct {
	smiUINT32 len;
	smiLPUINT32 ptr;
} smiOID, *smiLPOID;
typedef const smiLPOID smiLPCOID;
typedef struct {
	smiUINT32 hipart;
	smiUINT32 lopart;
} smiCNTR64, *smiLPCNTR64;
typedef struct {
	smiUINT32 syntax;
	union {
		smiINT sNumber;
		smiUINT32 uNumber;
		smiCNTR64 hNumber;
		smiOCTETS string;
		smiOID oid;
		smiBYTE empty;
	} value;
} smiVALUE, *smiLPVALUE;
typedef const smiLPVALUE smiLPCVALUE;
typedef struct {
	CHAR vendorName[MAXVENDORINFO*2];
	CHAR vendorContact[MAXVENDORINFO*2];
	CHAR vendorVersionId[MAXVENDORINFO];
	CHAR vendorVersionDate[MAXVENDORINFO];
	smiUINT32 vendorEnterprise;
} smiVENDORINFO, FAR *smiLPVENDORINFO;
typedef SNMPAPI_STATUS (CALLBACK *SNMPAPI_CALLBACK)(HSNMP_SESSION,HWND,UINT,WPARAM,LPARAM,LPVOID);
typedef struct
{
	HSNMP_ENTITY hEntity;
	HSNMP_SESSION hSession;
	smiUINT32 nTranslateMode;
	smiUINT32 nSnmpVersion;
	smiOCTETS dFriendlyName;
	smiUINT32 nAddressFamily;
	smiOCTETS dAddressString;
	smiUINT32 nRequestPort;
	smiUINT32 nNotificationPort;
	smiUINT32 nMaxMsgSize;
	smiOCTETS dEngineID;
	smiUINT32 nEngineBoots;
	smiUINT32 nEngineTime;
	smiUINT32 nEngineSeconds;
	smiUINT32 nRetransmitMode;
	smiTIMETICKS nPolicyTimeout;
	smiUINT32 nPolicyRetry;
	smiTIMETICKS nActualTimeout;
	smiUINT32 nActualRetry;
} smiENTITYINFO, *smiLPENTITYINFO;
typedef struct
{
	HSNMP_CONTEXT hContext;
	HSNMP_SESSION hSession;
	smiUINT32 nTranslateMode;
	smiUINT32 nSnmpVersion;
	smiOCTETS dFriendlyName;
	smiOCTETS dContextEngineID;
	smiOCTETS dContextName;
	smiOCTETS dSecurityName;
	smiUINT32 nSecurityModel;
	smiUINT32 nSecurityLevel;
	smiUINT32 nSecurityAuthProtocol;
	smiOCTETS dSecurityAuthKey;
	smiUINT32 nSecurityPrivProtocol;
	smiOCTETS dSecurityPrivKey;
} smiCONTEXTINFO, *smiLPCONTEXTINFO;

SNMPAPI_STATUS WINSNMPAPI SnmpCancelMsg(HSNMP_SESSION,smiINT32);
SNMPAPI_STATUS WINSNMPAPI SnmpCleanup(VOID);
SNMPAPI_STATUS WINSNMPAPI SnmpClose(HSNMP_SESSION);
SNMPAPI_STATUS WINSNMPAPI SnmpContextToStr(HSNMP_CONTEXT,smiLPOCTETS);
SNMPAPI_STATUS WINSNMPAPI SnmpCountVbl(HSNMP_VBL);
HSNMP_PDU WINSNMPAPI SnmpCreatePdu(HSNMP_SESSION,smiINT,smiINT32,smiINT,smiINT,HSNMP_VBL);
HSNMP_SESSION WINSNMPAPI SnmpCreateSession(HWND,UINT,SNMPAPI_CALLBACK,LPVOID);
HSNMP_VBL WINSNMPAPI SnmpCreateVbl(HSNMP_SESSION,smiLPCOID,smiLPCVALUE);
SNMPAPI_STATUS WINSNMPAPI SnmpDecodeMsg(HSNMP_SESSION,LPHSNMP_ENTITY,LPHSNMP_ENTITY,LPHSNMP_CONTEXT,LPHSNMP_PDU,smiLPCOCTETS);
SNMPAPI_STATUS WINSNMPAPI SnmpDeleteVb(HSNMP_VBL,smiUINT32);
HSNMP_PDU WINSNMPAPI SnmpDuplicatePdu(HSNMP_SESSION,HSNMP_PDU);
HSNMP_VBL WINSNMPAPI SnmpDuplicateVbl(HSNMP_SESSION,HSNMP_VBL);
SNMPAPI_STATUS WINSNMPAPI SnmpEncodeMsg(HSNMP_SESSION,HSNMP_ENTITY,HSNMP_ENTITY,HSNMP_CONTEXT,HSNMP_PDU,smiLPOCTETS);
SNMPAPI_STATUS WINSNMPAPI SnmpEntityToStr(HSNMP_ENTITY,smiUINT32,LPSTR);
SNMPAPI_STATUS WINSNMPAPI SnmpFreeContext(HSNMP_CONTEXT);
SNMPAPI_STATUS WINSNMPAPI SnmpFreeDescriptor(smiUINT32,smiLPOPAQUE);
SNMPAPI_STATUS WINSNMPAPI SnmpFreeEntity(HSNMP_ENTITY);
SNMPAPI_STATUS WINSNMPAPI SnmpFreePdu(HSNMP_PDU);
SNMPAPI_STATUS WINSNMPAPI SnmpFreeVbl(HSNMP_VBL);
SNMPAPI_STATUS WINSNMPAPI SnmpGetLastError(HSNMP_SESSION);
SNMPAPI_STATUS WINSNMPAPI SnmpGetPduData(HSNMP_PDU,smiLPINT,smiLPINT32,smiLPINT,smiLPINT,LPHSNMP_VBL);
SNMPAPI_STATUS WINSNMPAPI SnmpGetRetransmitMode(smiLPUINT32);
SNMPAPI_STATUS WINSNMPAPI SnmpGetRetry(HSNMP_ENTITY,smiLPUINT32,smiLPUINT32);
SNMPAPI_STATUS WINSNMPAPI SnmpGetTimeout(HSNMP_ENTITY,smiLPTIMETICKS,smiLPTIMETICKS);
SNMPAPI_STATUS WINSNMPAPI SnmpGetTranslateMode(smiLPUINT32);
SNMPAPI_STATUS WINSNMPAPI SnmpGetVb(HSNMP_VBL,smiUINT32,smiLPOID,smiLPVALUE);
SNMPAPI_STATUS WINSNMPAPI SnmpGetVendorInfo(smiLPVENDORINFO);
SNMPAPI_STATUS WINSNMPAPI SnmpListen(HSNMP_ENTITY,SNMPAPI_STATUS);
SNMPAPI_STATUS WINSNMPAPI SnmpOidCompare(smiLPCOID,smiLPCOID,smiUINT32,smiLPINT);
SNMPAPI_STATUS WINSNMPAPI SnmpOidCopy(smiLPCOID,smiLPOID);
SNMPAPI_STATUS WINSNMPAPI SnmpOidToStr(smiLPCOID,smiUINT32,LPSTR);
HSNMP_SESSION WINSNMPAPI SnmpOpen(HWND,UINT);
SNMPAPI_STATUS WINSNMPAPI SnmpRecvMsg(HSNMP_SESSION,LPHSNMP_ENTITY,LPHSNMP_ENTITY,LPHSNMP_CONTEXT,LPHSNMP_PDU);
SNMPAPI_STATUS WINSNMPAPI SnmpRegister(HSNMP_SESSION,HSNMP_ENTITY,HSNMP_ENTITY,HSNMP_CONTEXT,smiLPCOID,smiUINT32);
SNMPAPI_STATUS WINSNMPAPI SnmpSendMsg(HSNMP_SESSION,HSNMP_ENTITY,HSNMP_ENTITY,HSNMP_CONTEXT,HSNMP_PDU);
SNMPAPI_STATUS WINSNMPAPI SnmpSetPduData(HSNMP_PDU,const smiINT *,const smiINT32 *,const smiINT *,const smiINT *,const HSNMP_VBL *);
SNMPAPI_STATUS WINSNMPAPI SnmpSetPort(HSNMP_ENTITY,UINT);
SNMPAPI_STATUS WINSNMPAPI SnmpSetRetransmitMode(smiUINT32);
SNMPAPI_STATUS WINSNMPAPI SnmpSetRetry(HSNMP_ENTITY,smiUINT32);
SNMPAPI_STATUS WINSNMPAPI SnmpSetTimeout(HSNMP_ENTITY,smiTIMETICKS);
SNMPAPI_STATUS WINSNMPAPI SnmpSetTranslateMode(smiUINT32);
SNMPAPI_STATUS WINSNMPAPI SnmpSetVb(HSNMP_VBL,smiUINT32,smiLPCOID,smiLPCVALUE);
SNMPAPI_STATUS WINSNMPAPI SnmpStartup(smiLPUINT32,smiLPUINT32,smiLPUINT32,smiLPUINT32,smiLPUINT32);
HSNMP_CONTEXT WINSNMPAPI SnmpStrToContext(HSNMP_SESSION,smiLPCOCTETS);
HSNMP_ENTITY WINSNMPAPI SnmpStrToEntity(HSNMP_SESSION,LPCSTR);
SNMPAPI_STATUS WINSNMPAPI SnmpStrToOid(LPCSTR,smiLPOID);
/* Added in WinSNMP v3.0, not present in some (all?) versions of MS wsnmp32.dll */
HSNMP_ENTITY WINSNMPAPI SnmpCreateEntity(HSNMP_SESSION,smiLPENTITYINFO);
SNMPAPI_STATUS WINSNMPAPI SnmpGetEntityInfo(HSNMP_ENTITY,smiLPENTITYINFO);
SNMPAPI_STATUS WINSNMPAPI SnmpSetEntityInfo(HSNMP_ENTITY,smiLPENTITYINFO);
SNMPAPI_STATUS WINSNMPAPI SnmpFreeEntityInfo(smiLPENTITYINFO);
HSNMP_CONTEXT WINSNMPAPI SnmpCreateContext(HSNMP_SESSION,smiLPCONTEXTINFO);
SNMPAPI_STATUS WINSNMPAPI SnmpGetContextInfo(HSNMP_CONTEXT,smiLPCONTEXTINFO);
SNMPAPI_STATUS WINSNMPAPI SnmpSetContextInfo(HSNMP_CONTEXT,smiLPCONTEXTINFO);
SNMPAPI_STATUS WINSNMPAPI SnmpFreeContextInfo(smiLPCONTEXTINFO);
SNMPAPI_STATUS WINSNMPAPI SnmpPasswordToKey(smiLPOCTETS,smiINT32,smiLPOCTETS);

#endif /* RC_INVOKED */

#ifdef __cplusplus
}
#endif
#include <poppack.h>
#endif
