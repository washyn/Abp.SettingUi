﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EasyAbp.Abp.SettingUi.Dto;
using Volo.Abp.Application.Services;

namespace EasyAbp.Abp.SettingUi
{
    public interface ISettingUiAppService : IApplicationService
    {
        Task<List<SettingGroup>> GroupSettingDefinitions();
        Task SetSettingValues(Dictionary<string, string> settingValues);
        Task ResetSettingValues(List<string> settingNames);
    }
}