using Abp.Application.Navigation;
using Abp.Localization;
using CRUDreborn.Authorization;

namespace CRUDreborn.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class CRUDrebornNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", CRUDrebornConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home",
                        requiresAuthentication: true
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Tenants",
                        L("Tenants"),
                        url: "#tenants",
                        icon: "fa fa-globe",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Users",
                        L("Users"),
                        url: "#users",
                        icon: "fa fa-users",
                        requiredPermissionName: PermissionNames.Pages_Users
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Roles",
                        L("Roles"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", CRUDrebornConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Manufacturers",
                        new LocalizableString("Manufacturers", CRUDrebornConsts.LocalizationSourceName),
                        url: "#/manufacturers",
                        icon: "fa fa-building"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Products",
                        new LocalizableString("Products", CRUDrebornConsts.LocalizationSourceName),
                        url: "#/products",
                        icon: "fa fa-cart-arrow-down"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Stock",
                        new LocalizableString("Stock", CRUDrebornConsts.LocalizationSourceName),
                        url: "#/stock",
                        icon: "fa fa-archive"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Sales",
                        new LocalizableString("Sales", CRUDrebornConsts.LocalizationSourceName),
                        url: "#/sales",
                        icon: "fa fa-money-bill-alt"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, CRUDrebornConsts.LocalizationSourceName);
        }
    }
}
