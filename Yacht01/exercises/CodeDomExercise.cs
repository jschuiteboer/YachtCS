using Microsoft.CSharp;
using System.CodeDom;
using System.CodeDom.Compiler;

namespace Yacht01.exercises
{
    class CodeDomExercise
    {
        public static void Run(string[] args)
        {
            CodeCompileUnit codeCompileUnit = new CodeCompileUnit();
            CodeNamespace codeNameSpace = new CodeNamespace("MyNamespace");
            CodeNamespaceImport codeNamespaceImport = new CodeNamespaceImport("System");
            CodeTypeDeclaration codeTypeDeclaration = new CodeTypeDeclaration("MyClass");
            CodeEntryPointMethod codeEntryPointMethod = new CodeEntryPointMethod();
            CodeMethodInvokeExpression codeMethodInvokeExpression = new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression("Console"),
                "WriteLine",
                new CodePrimitiveExpression("Test!")
            );

            codeCompileUnit.Namespaces.Add(codeNameSpace);
            codeNameSpace.Imports.Add(codeNamespaceImport);
            codeNameSpace.Types.Add(codeTypeDeclaration);
            codeTypeDeclaration.Members.Add(codeEntryPointMethod);
            codeEntryPointMethod.Statements.Add(codeMethodInvokeExpression);
        }
    }
}
