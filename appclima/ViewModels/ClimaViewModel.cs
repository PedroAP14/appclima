using appclima.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace appclima.ViewModels
{
    internal class ClimaViewModel
    {
        [ObservableProperty]
        private string cidade;
        [ObservableProperty]
        private string estado;
        [ObservableProperty]
        private DateTime atualizado_em;
        [ObservableProperty]
        private List<Clima> clima;

        public ClimaViewModel()
        {
            cidade = "Guarulhos";
        }

        public void getPrevisao()
        {
            cidade = "São Paulo";
        }
    }
}
