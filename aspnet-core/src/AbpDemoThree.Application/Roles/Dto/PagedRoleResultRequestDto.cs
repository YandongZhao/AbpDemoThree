﻿using Abp.Application.Services.Dto;

namespace AbpDemoThree.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

