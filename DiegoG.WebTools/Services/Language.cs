﻿using DiegoG.WebTools.Pages;
using System;
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Reflection;

namespace DiegoG.WebTools.Services;

public sealed class Language
{
    public required string LanguageName { get; set; }
    public required string LanguageCode { get; init; }
    public required string AboutMeUri { get; init; }
    public required string AboutMe { get; init; }
    public required string CVUri { get; init; }
    public required string Home { get; init; }
    public required string QRCodeGen { get; init; }
    public required string SiteTitle { get; init; }
    public required string ShortSiteTitle { get; init; }
    public required string QRContent { get; init; }
    public required string QRPPM { get; init; }
    public required string QRECC { get; init; }
    public required string QRECIMode { get; init; }
    public required string QRForceUTF8 { get; init; }
    public required string QRUTF8Bom { get; init; }
    public required string QRRequestedVersion { get; init; }
    public required string SubmitButton { get; init; }
    public required string NotFoundTitle { get; init; }
    public required string NotFoundMessage { get; init; }
}

public static class AvailableLanguages
{
    static AvailableLanguages()
    {
        Español = new Language()
        {
            LanguageName = "Español",
            LanguageCode = "es",
            AboutMeUri = "https://raw.githubusercontent.com/DiegoG1019/DiegoG1019/refs/heads/main/README-spanish.md",
            AboutMe = "Sobre Mí",
            CVUri = "/Diego CV - ESPAÑOL - DEC24.pdf",
            Home = "Principal",
            QRCodeGen = "Generador de QRs",
            SiteTitle = "Ingr. Dev DiegoG",
            ShortSiteTitle = "Dev DiegoG",
            QRContent = "Contenido: ",
            QRPPM = "Píxeles por Módulo: ",
            QRECC = "ECC: ",
            QRECIMode = "Modo Eci: ",
            QRForceUTF8 = "Forzar UTF-8? ",
            QRUTF8Bom = "Incluir el BOM en UTF-8? ",
            QRRequestedVersion = "Version de Código QR: ",
            SubmitButton = "Generar",
            NotFoundTitle = "No Encontrado",
            NotFoundMessage = "Lo siento, no hay nada en esta dirección"
        };

        English = new Language()
        {
            LanguageName = "English",
            LanguageCode = "en",
            AboutMeUri = "https://raw.githubusercontent.com/DiegoG1019/DiegoG1019/refs/heads/main/README.md",
            AboutMe = "About Me",
            CVUri = "/Diego CV - ENGLISH - DEC24.pdf",
            Home = "Home",
            QRCodeGen = "QR-Code Generator",
            SiteTitle = "Dev Engr. DiegoG & Tools",
            ShortSiteTitle = "Dev DiegoG",
            QRContent = "Content: ",
            QRPPM = "Pixels per Module: ",
            QRECC = "ECC: ",
            QRECIMode = "Eci Mode: ",
            QRForceUTF8 = "Force UTF8? ",
            QRUTF8Bom = "Include BOM in UTF-8? ",
            QRRequestedVersion = "QR Code Version: ",
            SubmitButton = "Submit",
            NotFoundTitle = "Not Found",
            NotFoundMessage = "Sorry, there's nothing at this address"
        };

        Languages = typeof(AvailableLanguages).GetProperties()
                                                  .Where(x => x.PropertyType == typeof(Language))
                                                  .Select(x => x.GetValue(null))
                                                  .Cast<Language>()
                                                  .ToFrozenDictionary(
                                                      v => v.LanguageCode,
                                                      k => k
                                                  );
    }

    public static FrozenDictionary<string, Language> Languages { get; }

    public static Language Español { get; }

    public static Language English { get; }
}