using Bogus;
using System.Collections.Generic;

namespace NaughtyStrings.Bogus
{
    public class Naughty : DataSet
    {
        /// <summary>
        /// All naughty strings.
        /// </summary>
        public IEnumerable<string> Strings(int num = 1)
        {
            return TheNaughtyStrings.All.PickRandom(num);
        }
        /// <summary>
        /// A naughty string.
        /// </summary>
        public string String()
        {
            return TheNaughtyStrings.All.PickRandom();
        }

        /// <summary>
        ///  Strings which may be used elsewhere in code
        /// </summary>
        public IEnumerable<string> ReservedStrings(int num = 1)
        {
            return TheNaughtyStrings.ReservedStrings.PickRandom(num);
        }
        /// <summary>
        ///  Strings which may be used elsewhere in code
        /// </summary>
        public string ReservedString()
        {
            return TheNaughtyStrings.ReservedStrings.PickRandom();
        }

        /// <summary>
        ///  Strings which can be interpreted as numeric
        /// </summary>
        public IEnumerable<string> NumericStrings(int num = 1)
        {
            return TheNaughtyStrings.NumericStrings.PickRandom(num);
        }
        /// <summary>
        ///  Strings which can be interpreted as numeric
        /// </summary>
        public string NumericString()
        {
            return TheNaughtyStrings.NumericStrings.PickRandom();
        }

        /// <summary>
        ///  ASCII punctuation.  All of these characters may need to be escaped in some contexts.  Divided into three groups based on (US-layout) keyboard position.
        /// </summary>
        public IEnumerable<string> SpecialCharacters(int num = 1)
        {
            return TheNaughtyStrings.SpecialCharacters.PickRandom(num);
        }
        /// <summary>
        ///  ASCII punctuation.  All of these characters may need to be escaped in some contexts.  Divided into three groups based on (US-layout) keyboard position.
        /// </summary>
        public string SpecialCharacter()
        {
            return TheNaughtyStrings.SpecialCharacters.PickRandom();
        }

        /// <summary>
        ///  Strings which contain common unicode symbols (e.g. smart quotes)
        /// </summary>
        public IEnumerable<string> UnicodeSymbols(int num = 1)
        {
            return TheNaughtyStrings.UnicodeSymbols.PickRandom(num);
        }
        /// <summary>
        ///  Strings which contain common unicode symbols (e.g. smart quotes)
        /// </summary>
        public string UnicodeSymbol()
        {
            return TheNaughtyStrings.UnicodeSymbols.PickRandom();
        }

        /// <summary>
        ///  Strings which contain unicode subscripts/superscripts; can cause rendering issues
        /// </summary>
        public IEnumerable<string> UnicodeSubscriptSuperscriptAccents(int num = 1)
        {
            return TheNaughtyStrings.UnicodeSubscriptSuperscriptAccents.PickRandom(num);
        }
        /// <summary>
        ///  Strings which contain unicode subscripts/superscripts; can cause rendering issues
        /// </summary>
        public string UnicodeSubscriptSuperscriptAccent()
        {
            return TheNaughtyStrings.UnicodeSubscriptSuperscriptAccents.PickRandom();
        }

        /// <summary>
        ///  Strings which contain misplaced quotation marks; can cause encoding errors
        /// </summary>
        public IEnumerable<string> QuotationMarks(int num = 1)
        {
            return TheNaughtyStrings.QuotationMarks.PickRandom(num);
        }
        /// <summary>
        ///  Strings which contain misplaced quotation marks; can cause encoding errors
        /// </summary>
        public string QuotationMark()
        {
            return TheNaughtyStrings.QuotationMarks.PickRandom();
        }

        /// <summary>
        ///  Strings which contain two-byte characters: can cause rendering issues or character-length issues
        /// </summary>
        public IEnumerable<string> TwoByteCharacters(int num = 1)
        {
            return TheNaughtyStrings.TwoByteCharacters.PickRandom(num);
        }
        /// <summary>
        ///  Strings which contain two-byte characters: can cause rendering issues or character-length issues
        /// </summary>
        public string TwoByteCharacter()
        {
            return TheNaughtyStrings.TwoByteCharacters.PickRandom();
        }

        /// <summary>
        ///  Characters which increase in length (2 to 3 bytes) when lowercased Credit: https://twitter.com/jifa/status/625776454479970304
        /// </summary>
        public IEnumerable<string> Changinglengthwhenlowercased(int num = 1)
        {
            return TheNaughtyStrings.Changinglengthwhenlowercased.PickRandom(num);
        }
        /// <summary>
        ///  Characters which increase in length (2 to 3 bytes) when lowercased Credit: https://twitter.com/jifa/status/625776454479970304
        /// </summary>
        public string Changinglengthwhenlowercased()
        {
            return TheNaughtyStrings.Changinglengthwhenlowercased.PickRandom();
        }

        /// <summary>
        ///  Strings which consists of Japanese-style emoticons which are popular on the web
        /// </summary>
        public IEnumerable<string> JapaneseEmoticons(int num = 1)
        {
            return TheNaughtyStrings.JapaneseEmoticons.PickRandom(num);
        }
        /// <summary>
        ///  Strings which consists of Japanese-style emoticons which are popular on the web
        /// </summary>
        public string JapaneseEmoticon()
        {
            return TheNaughtyStrings.JapaneseEmoticons.PickRandom();
        }

        /// <summary>
        ///  Strings which contain Emoji; should be the same behavior as two-byte characters, but not always
        /// </summary>
        public IEnumerable<string> Emoji(int num = 1)
        {
            return TheNaughtyStrings.Emoji.PickRandom(num);
        }
        /// <summary>
        ///  Strings which contain Emoji; should be the same behavior as two-byte characters, but not always
        /// </summary>
        public string Emoji()
        {
            return TheNaughtyStrings.Emoji.PickRandom();
        }

        /// <summary>
        ///  Strings which contain unicode numbers; if the code is localized, it should see the input as numeric
        /// </summary>
        public IEnumerable<string> UnicodeNumbers(int num = 1)
        {
            return TheNaughtyStrings.UnicodeNumbers.PickRandom(num);
        }
        /// <summary>
        ///  Strings which contain unicode numbers; if the code is localized, it should see the input as numeric
        /// </summary>
        public string UnicodeNumber()
        {
            return TheNaughtyStrings.UnicodeNumbers.PickRandom();
        }

        /// <summary>
        ///  Strings which contain text that should be rendered RTL if possible (e.g. Arabic, Hebrew)
        /// </summary>
        public IEnumerable<string> RightToLeftStrings(int num = 1)
        {
            return TheNaughtyStrings.RightToLeftStrings.PickRandom(num);
        }
        /// <summary>
        ///  Strings which contain text that should be rendered RTL if possible (e.g. Arabic, Hebrew)
        /// </summary>
        public string RightToLeftString()
        {
            return TheNaughtyStrings.RightToLeftStrings.PickRandom();
        }

        /// <summary>
        ///  Strings which contain unicode with unusual properties (e.g. Right-to-left override) (c.f. http://www.unicode.org/charts/PDF/U2000.pdf)
        /// </summary>
        public IEnumerable<string> TrickUnicode(int num = 1)
        {
            return TheNaughtyStrings.TrickUnicode.PickRandom(num);
        }
        /// <summary>
        ///  Strings which contain unicode with unusual properties (e.g. Right-to-left override) (c.f. http://www.unicode.org/charts/PDF/U2000.pdf)
        /// </summary>
        public string TrickUnicode()
        {
            return TheNaughtyStrings.TrickUnicode.PickRandom();
        }

        /// <summary>
        ///  Strings which contain "corrupted" text. The corruption will not appear in non-HTML text, however. (via http://www.eeemo.net)
        /// </summary>
        public IEnumerable<string> ZalgoText(int num = 1)
        {
            return TheNaughtyStrings.ZalgoText.PickRandom(num);
        }
        /// <summary>
        ///  Strings which contain "corrupted" text. The corruption will not appear in non-HTML text, however. (via http://www.eeemo.net)
        /// </summary>
        public string ZalgoText()
        {
            return TheNaughtyStrings.ZalgoText.PickRandom();
        }

        /// <summary>
        ///  Strings which contain unicode with an "upsidedown" effect (via http://www.upsidedowntext.com)
        /// </summary>
        public IEnumerable<string> UnicodeUpsidedown(int num = 1)
        {
            return TheNaughtyStrings.UnicodeUpsidedown.PickRandom(num);
        }
        /// <summary>
        ///  Strings which contain unicode with an "upsidedown" effect (via http://www.upsidedowntext.com)
        /// </summary>
        public string UnicodeUpsidedown()
        {
            return TheNaughtyStrings.UnicodeUpsidedown.PickRandom();
        }

        /// <summary>
        ///  Strings which contain bold/italic/etc. versions of normal characters
        /// </summary>
        public IEnumerable<string> Unicodefont(int num = 1)
        {
            return TheNaughtyStrings.Unicodefont.PickRandom(num);
        }
        /// <summary>
        ///  Strings which contain bold/italic/etc. versions of normal characters
        /// </summary>
        public string Unicodefont()
        {
            return TheNaughtyStrings.Unicodefont.PickRandom();
        }

        /// <summary>
        ///  Strings which attempt to invoke a benign script injection; shows vulnerability to XSS
        /// </summary>
        public IEnumerable<string> ScriptInjection(int num = 1)
        {
            return TheNaughtyStrings.ScriptInjection.PickRandom(num);
        }
        /// <summary>
        ///  Strings which attempt to invoke a benign script injection; shows vulnerability to XSS
        /// </summary>
        public string ScriptInjection()
        {
            return TheNaughtyStrings.ScriptInjection.PickRandom();
        }

        /// <summary>
        ///  Strings which can cause a SQL injection if inputs are not sanitized
        /// </summary>
        public IEnumerable<string> SQLInjection(int num = 1)
        {
            return TheNaughtyStrings.SQLInjection.PickRandom(num);
        }
        /// <summary>
        ///  Strings which can cause a SQL injection if inputs are not sanitized
        /// </summary>
        public string SQLInjection()
        {
            return TheNaughtyStrings.SQLInjection.PickRandom();
        }

        /// <summary>
        ///  Strings which can cause user to run code on server as a privileged user (c.f. https://news.ycombinator.com/item?id=7665153)
        /// </summary>
        public IEnumerable<string> ServerCodeInjection(int num = 1)
        {
            return TheNaughtyStrings.ServerCodeInjection.PickRandom(num);
        }
        /// <summary>
        ///  Strings which can cause user to run code on server as a privileged user (c.f. https://news.ycombinator.com/item?id=7665153)
        /// </summary>
        public string ServerCodeInjection()
        {
            return TheNaughtyStrings.ServerCodeInjection.PickRandom();
        }

        /// <summary>
        ///  Strings which can call system commands within Ruby/Rails applications
        /// </summary>
        public IEnumerable<string> CommandInjectionRuby(int num = 1)
        {
            return TheNaughtyStrings.CommandInjectionRuby.PickRandom(num);
        }
        /// <summary>
        ///  Strings which can call system commands within Ruby/Rails applications
        /// </summary>
        public string CommandInjectionRuby()
        {
            return TheNaughtyStrings.CommandInjectionRuby.PickRandom();
        }

        /// <summary>
        ///  Strings which can be accidentally expanded into different strings if evaluated in the wrong context, e.g. used as a printf format string or via Perl or shell eval. Might expose sensitive data from the program doing the interpolation, or might just represent the wrong string.
        /// </summary>
        public IEnumerable<string> UnwantedInterpolation(int num = 1)
        {
            return TheNaughtyStrings.UnwantedInterpolation.PickRandom(num);
        }
        /// <summary>
        ///  Strings which can be accidentally expanded into different strings if evaluated in the wrong context, e.g. used as a printf format string or via Perl or shell eval. Might expose sensitive data from the program doing the interpolation, or might just represent the wrong string.
        /// </summary>
        public string UnwantedInterpolation()
        {
            return TheNaughtyStrings.UnwantedInterpolation.PickRandom();
        }

        /// <summary>
        ///  Strings which can cause user to pull in files that should not be a part of a web server
        /// </summary>
        public IEnumerable<string> FileInclusion(int num = 1)
        {
            return TheNaughtyStrings.FileInclusion.PickRandom(num);
        }
        /// <summary>
        ///  Strings which can cause user to pull in files that should not be a part of a web server
        /// </summary>
        public string FileInclusion()
        {
            return TheNaughtyStrings.FileInclusion.PickRandom();
        }

        /// <summary>
        ///  Strings that test for known vulnerabilities
        /// </summary>
        public IEnumerable<string> KnownCVEsandVulnerabilities(int num = 1)
        {
            return TheNaughtyStrings.KnownCVEsandVulnerabilities.PickRandom(num);
        }
        /// <summary>
        ///  Strings that test for known vulnerabilities
        /// </summary>
        public string KnownCVEsandVulnerabilitie()
        {
            return TheNaughtyStrings.KnownCVEsandVulnerabilities.PickRandom();
        }

        /// <summary>
        ///  Strings which are reserved characters in MSDOS/Windows
        /// </summary>
        public IEnumerable<string> MSDOSWindowsSpecialFilenames(int num = 1)
        {
            return TheNaughtyStrings.MSDOSWindowsSpecialFilenames.PickRandom(num);
        }
        /// <summary>
        ///  Strings which are reserved characters in MSDOS/Windows
        /// </summary>
        public string MSDOSWindowsSpecialFilename()
        {
            return TheNaughtyStrings.MSDOSWindowsSpecialFilenames.PickRandom();
        }

        /// <summary>
        ///  Innocuous strings which may be blocked by profanity filters (https://en.wikipedia.org/wiki/Scunthorpe_problem)
        /// </summary>
        public IEnumerable<string> ScunthorpeProblem(int num = 1)
        {
            return TheNaughtyStrings.ScunthorpeProblem.PickRandom(num);
        }
        /// <summary>
        ///  Innocuous strings which may be blocked by profanity filters (https://en.wikipedia.org/wiki/Scunthorpe_problem)
        /// </summary>
        public string ScunthorpeProblem()
        {
            return TheNaughtyStrings.ScunthorpeProblem.PickRandom();
        }

        /// <summary>
        ///  Strings which may cause human to reinterpret worldview
        /// </summary>
        public IEnumerable<string> Humaninjection(int num = 1)
        {
            return TheNaughtyStrings.Humaninjection.PickRandom(num);
        }
        /// <summary>
        ///  Strings which may cause human to reinterpret worldview
        /// </summary>
        public string Humaninjection()
        {
            return TheNaughtyStrings.Humaninjection.PickRandom();
        }

        /// <summary>
        ///  Strings which punish the fools who use cat/type on this file
        /// </summary>
        public IEnumerable<string> Terminalescapecodes(int num = 1)
        {
            return TheNaughtyStrings.Terminalescapecodes.PickRandom(num);
        }
        /// <summary>
        ///  Strings which punish the fools who use cat/type on this file
        /// </summary>
        public string Terminalescapecode()
        {
            return TheNaughtyStrings.Terminalescapecodes.PickRandom();
        }

        /// <summary>
        ///  Strings which crashed iMessage in various versions of iOS
        /// </summary>
        public IEnumerable<string> iOSVulnerabilities(int num = 1)
        {
            return TheNaughtyStrings.iOSVulnerabilities.PickRandom(num);
        }
        /// <summary>
        ///  Strings which crashed iMessage in various versions of iOS
        /// </summary>
        public string iOSVulnerabilitie()
        {
            return TheNaughtyStrings.iOSVulnerabilities.PickRandom();
        }

    }
}
