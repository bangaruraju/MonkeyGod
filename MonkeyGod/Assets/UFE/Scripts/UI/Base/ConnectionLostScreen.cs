﻿using UnityEngine;
using System.Collections;

public class ConnectionLostScreen : UFEScreen{
	public virtual void GoToMainMenu(){
		UFE.StartMainMenuScreen();
	}

	public virtual void GoToNetworkGameScreen(){
		UFE.StartNetworkGameScreen();
	}

}
