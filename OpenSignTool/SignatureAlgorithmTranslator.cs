﻿using System;
using System.Security.Cryptography;

namespace OpenSignTool
{
    internal static class SignatureAlgorithmTranslator
    {
        public static string SignatureAlgorithmToJwsAlgId(HashAlgorithmName hashAlgorithmName)
        {
                if (hashAlgorithmName.Name == HashAlgorithmName.SHA256.Name)
                    return "RS256";
                if (hashAlgorithmName.Name == HashAlgorithmName.SHA384.Name)
                    return "RS384";
                if (hashAlgorithmName.Name == HashAlgorithmName.SHA512.Name)
                    return "RS512";
                throw new NotSupportedException("The algorithm specified is not supported.");

        }
    }
}
