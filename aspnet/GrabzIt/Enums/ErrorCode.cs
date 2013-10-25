﻿using System;

namespace GrabzIt.Enums
{
    public enum ErrorCode
    {
        Success = 0,
        ParameterNoURL = 100,
        ParameterInvalidURL = 101,
        ParameterNonExistantURL = 102,
        ParameterMissingApplicationKey = 103,
        ParameterUnrecognisedApplicationKey = 104,
        ParameterMissingSignature = 105,
        ParameterInvalidSignature = 106,
        ParameterInvalidFormat = 107,
        ParameterInvalidCountryCode = 108,
        ParameterDuplicateIdentifier = 109,
        ParameterMatchingRecordNotFound = 110,
        ParameterInvalidCallBackURL = 111,
        ParameterNonExistantCallBackURL = 112,
        ParameterImageWidthTooLarge = 113,
        ParameterImageHeightTooLarge = 114,
        ParameterBrowserWidthTooLarge = 115,
        ParameterBrowserHeightTooLarge = 116,
        ParameterDelayTooLarge = 117,
        ParameterInvalidBackground = 118,
        ParameterInvalidIncludeLinks = 119,
        ParameterInvalidIncludeOutline = 120,
        ParameterInvalidPageSize = 121,
        ParameterInvalidPageOrientation = 122,
        ParameterVerticalMarginTooLarge = 123,
        ParameterHorizontalMarginTooLarge = 124,
        ParameterInvalidCoverUrl = 125,
        ParameterNonExistantCoverUrl = 126,
        ParameterMissingCookieName = 127,
        ParameterMissingCookieDomain = 128,
        ParameterInvalidCookieName = 129,
        ParameterInvalidCookieDomain = 130,
        ParameterInvalidCookieDelete = 131,
        ParameterInvalidCookieHTTP = 132,
        ParameterInvalidCookieExpiry = 133,
        ParameterInvalidCacheValue = 134,
        ParameterInvalidDownloadValue = 135,
        ParameterInvalidSupressValue = 136,
        ParameterMissingWaterMarkIdentifier = 137,
        ParameterInvalidWaterMarkIdentifier = 138,
        ParameterInvalidWaterMarkXPos = 139,
        ParameterInvalidWaterMarkYPos = 140,
        ParameterMissingWaterMarkFormat = 141,
        ParameterWaterMarkTooLarge = 142,
        ParameterMissingParameters = 143,
        NetworkServerOffline = 200,
        NetworkGeneralError = 201,
        NetworkDDOSAttack = 202,
        RenderingError = 300,
        RenderingMissingScreenshot = 301,
        GenericError = 400,
        UpgradeRequired = 500,
        FileSaveError = 600,
        FileNonExistantPath = 601
    }
}