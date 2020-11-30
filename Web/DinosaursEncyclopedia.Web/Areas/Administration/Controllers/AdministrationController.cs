namespace DinosaursEncyclopedia.Web.Areas.Administration.Controllers
{
    using DinosaursEncyclopedia.Common;
    using DinosaursEncyclopedia.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
