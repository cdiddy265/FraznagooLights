﻿namespace CSCorePlaying
{
	public interface ISpectrumProvider
	{
		bool GetFftData(float[] fftBuffer, object context);
		int GetFftBandIndex(float frequency);
	}
}