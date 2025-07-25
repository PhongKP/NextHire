﻿using NextHireApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NextHireApp.Permissions;

public class NextHireAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NextHireAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NextHireAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NextHireAppResource>(name);
    }
}
