using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                /// Provides methods for generate differences between texts
                /// </summary>
                /// <description>
                /// ![Created for sample demo test](Dove_5c3ebe289226122fec496a39.jpeg)
                /// </description>
                            public interface IDiffer
    {
        
        /// <summary>
        /// </summary>
        /// <description>
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