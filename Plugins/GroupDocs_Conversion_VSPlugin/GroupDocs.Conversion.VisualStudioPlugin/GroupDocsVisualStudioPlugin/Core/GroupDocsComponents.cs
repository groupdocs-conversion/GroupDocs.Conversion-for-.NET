// Copyright (c) Aspose 2002-2016. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GroupDocsConversionVisualStudioPlugin.Core
{
    public class GroupDocsComponents
    {
        public static Dictionary<String, GroupDocsComponent> list = new Dictionary<string, GroupDocsComponent>();
        public GroupDocsComponents()
        {
            list.Clear();

            GroupDocsComponent groupdocsConversion = new GroupDocsComponent();
            groupdocsConversion.set_downloadUrl("");
            groupdocsConversion.set_downloadFileName("groupdocs.Conversion.zip");
            groupdocsConversion.set_name(Constants.GROUPDOCS_COMPONENT);
            groupdocsConversion.set_remoteExamplesRepository("https://github.com/groupdocs-Conversion/GroupDocs.Conversion-for-.NET.git");
            list.Add(Constants.GROUPDOCS_COMPONENT, groupdocsConversion);
        }
    }
}
