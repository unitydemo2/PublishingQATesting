using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                /// Provides methods for generate differences between texts
                /// </summary>
                /// <description>
                /// This is created for testing the description of interface
                /// </description>
                            public interface IDiffer
    {
        
        /// <summary>
        /// Created for testing the CreateLineDiffs Method summary.
        /// </summary>
        /// <description>
        /// ![](Merc-ScriptRef_5c583063a926c225d45d3370.jpeg)
        /// </description>
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
        
        /// <summary>
        /// </summary>
        /// <description>
        /// </description>
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
    }
}