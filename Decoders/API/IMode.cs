﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace wcm.wspectra.decoders
{
	public interface IMode : INotifyPropertyChanged
	{
		/// <summary>
		/// Name of the mode
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Status of the mode (i.e. synchronizing, idle, etc)
		/// </summary>
		string Status { get; }

		/// <summary>
		/// Confidence of the mode results. Ranges from 0 to 100. Negative values indicate that the mode does not offer confidence information
		/// </summary>
		int Confidence { get; }
		/// <summary>
		/// Parameters of the mode
		/// </summary>
		IEnumerable<IParameter> Parameters { get; }

		/// <summary>
		/// name based parameter accessor
		/// </summary>
		/// <param name="aParamName">Name of the parameter to retrieve</param>
		/// <returns>The parameter with the given name if found, null otherwise</returns>
		IParameter this[string aParamName] { get; }

	}
}