﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remotely_ScreenCast.Capture
{
	public interface ICapturer
	{
		Bitmap CurrentFrame { get; set; }
        Size CurrentScreenSize { get; }

        Bitmap PreviousFrame { get; set; }
		bool CaptureFullscreen { get; set; }
		void Capture();
        EventHandler<Size> ScreenChanged { get; set; }
        int SelectedScreen { get; set; }
    }
}