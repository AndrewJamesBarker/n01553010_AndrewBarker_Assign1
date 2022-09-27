using System;
using System.Reflection;

namespace n01553010_AndrewBarker_Assign1.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}