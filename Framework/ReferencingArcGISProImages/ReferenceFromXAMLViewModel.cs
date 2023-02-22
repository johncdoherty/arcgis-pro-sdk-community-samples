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
using ArcGIS.Core.CIM;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Editing;
using ArcGIS.Desktop.Extensions;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Dialogs;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Layouts;
using ArcGIS.Desktop.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ReferencingArcGISProImages
{
  internal class ReferenceFromXAMLViewModel : DockPane
  {
    private const string _dockPaneID = "ReferencingArcGISProImages_ReferenceFromXAML";

    protected ReferenceFromXAMLViewModel() { }

    /// <summary>
    /// Show the DockPane.
    /// </summary>
    internal static void Show()
    {
      DockPane pane = FrameworkApplication.DockPaneManager.Find(_dockPaneID);
      if (pane == null)
        return;

      pane.Activate();
    }

    public ImageSource ColorSelector32
    {
      get
      {
        var imageSource = System.Windows.Application.Current.Resources["ColorSelector32"] as ImageSource;
        return imageSource;
      }
    }

    public ImageSource AddinImageSource
    {
      get
      {
        var uri = new Uri ("pack://application:,,,/ReferencingArcGISProImages;component/Images/AddinDesktop32.png", UriKind.Absolute);
        var imageSource = new BitmapImage (uri) as ImageSource;
        return imageSource;
      }
    }

    /// <summary>
    /// Text shown near the top of the DockPane.
    /// </summary>
    private string _heading = "Dockpane with ArcGIS Pro images";
    public string Heading
    {
      get => _heading;
      set => SetProperty(ref _heading, value);
    }
  }

  /// <summary>
  /// Button implementation to show the DockPane.
  /// </summary>
	internal class ReferenceFromXAML_ShowButton : Button
  {
    protected override void OnClick()
    {
      ReferenceFromXAMLViewModel.Show();
    }
  }
}
