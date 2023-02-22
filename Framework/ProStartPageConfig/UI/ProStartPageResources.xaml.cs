/*

   Copyright 2023 Esri

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       https://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

   See the License for the specific language governing permissions and
   limitations under the License.

*/
using ArcGIS.Desktop.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProStartPageConfig.UI
{
  /// <summary>
  /// Interaction logic for ProStartPageResources.xaml
  /// </summary>
  public partial class ProStartPageResources : UserControl
  {
    public event PropertyChangedEventHandler PropertyChanged = delegate { };

    public ProStartPageResources()
    {
      InitializeComponent();
      (this.BodyContent as FrameworkElement).DataContext = this;
    }

    protected virtual void NotifyPropertyChanged([CallerMemberName] string propName = "")
    {
      PropertyChanged(this, new PropertyChangedEventArgs(propName));
    }
  }
}
