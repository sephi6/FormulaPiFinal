// UI Pack : Toony PRO
// Version: 1.0.0
// Author: Gold Experience Team (http://ge-team.com/pages/unity-3d/)
// Support: geteamdev@gmail.com
// Please direct any bugs/comments/suggestions to support e-mail (geteamdev@gmail.com)

#region Namespaces

	using UnityEngine;
	using System.Collections;

#endregion

// Collection of Graphic Quality for sample use in Setting panel
public enum eGraphicQuality
{
	Low,
	Medium,
	High
}

// ######################################################################
// This class is Singleton Pattern.
// It contains global confiurations to use in Setting panel in Home and Gameplay scenes.
// - Save function saves the config variables to PlayerPref.
// - Load function loads them back from PlayerPref
// - LoadDefault function sets current configs to default values.
// ######################################################################

public class Demo_Config : MonoBehaviour
{

	#region Variables

		// Private reference which can be accessed by this class only
		private static Demo_Config instance;

		// Public static reference that can be accesd from anywhere
		public static Demo_Config Instance
		{
			get
			{
				// Check if instance has not been set yet and set it it is not set already
				// This takes place only on the first time usage of this reference
				if(instance==null)
				{
					instance = GameObject.FindObjectOfType<Demo_Config>();
					if(instance==null)
					{
						GameObject pGameObject = new GameObject();
						pGameObject.name = "Config";
						instance = pGameObject.AddComponent<Demo_Config>();
					}				

					DontDestroyOnLoad(instance.gameObject);
				}
				return instance;
			}
		}

		// Default configs
		public float m_Music_Default				=	0.5f;
		public float m_Sound_Default				=	0.5f;
		public bool m_Vibration_Default				=	true;
		public bool m_AutoUpdate_Default			=	true;
		public bool m_Notifications_Default			=	true;
		public eGraphicQuality m_Quality_Default	=	eGraphicQuality.High;

		// Current configs
		public float m_Music				=	0.5f;
		public float m_Sound				=	0.5f;
		public bool m_Vibration				=	false;
		public bool m_AutoUpdate			=	false;
		public bool m_Notifications			=	false;
		public eGraphicQuality m_Quality	=	eGraphicQuality.High;
    
    #endregion //Variables
    
	// ######################################################################
	// MonoBehaviour functions
	// ######################################################################
	
	#region MonoBehaviour
		
		// Awake is called when the script instance is being loaded.
		void Awake()
		{
			if(instance == null)
			{
				// Make the current instance as the singleton
				instance = this;

				// Make it persistent  
				DontDestroyOnLoad(this);
			}
			else
			{
				// If more than one singleton exists in the scene find the existing reference from the scene and destroy it
				if(this != instance)
				{
					Destroy(this.gameObject);
				}
			}
		}
		
		// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
		void Start ()
		{
			
		}
		
		// Update is called every frame, if the MonoBehaviour is enabled.
		void Update ()
		{
			
		}
	
	#endregion //MonoBehaviour Functions
    
	// ######################################################################
	// Save and Load Functions
	// ######################################################################
	
	#region Save and Load Functions

		// Save to PlayerPrefs
		public void Save()
		{
			PlayerPrefs.SetInt("PlayerPrefsIsAlreadyUsed", 1);

			PlayerPrefs.SetFloat("Music", m_Music);

			PlayerPrefs.SetFloat("Sound", m_Sound);

			if(m_Vibration==true)
			{
				PlayerPrefs.SetInt("Vibration", 1);
			}
			else
			{
				PlayerPrefs.SetInt("Vibration", 0);
			}
		
			if(m_AutoUpdate==true)
			{
				PlayerPrefs.SetInt("AutoUpdate", 1);
			}
			else
			{
				PlayerPrefs.SetInt("AutoUpdate", 0);
			}
		
			if(m_Notifications==true)
			{
				PlayerPrefs.SetInt("Notifications", 1);
			}
			else
			{
				PlayerPrefs.SetInt("Notifications", 0);
			}

			switch(m_Quality)
			{
				case eGraphicQuality.Low: 
					PlayerPrefs.SetInt("GraphicQuality", 0); 
					break;
				case eGraphicQuality.Medium: 
					PlayerPrefs.SetInt("GraphicQuality", 1); 
					break;
				case eGraphicQuality.High: 
					PlayerPrefs.SetInt("GraphicQuality", 2); 
					break;
			}
		}
	
		// Load from PlayerPrefs
		public void Load()
		{
			int PlayerPrefsIsAlreadyUsed = PlayerPrefs.GetInt("PlayerPrefsIsAlreadyUsed");
			if(PlayerPrefsIsAlreadyUsed==1)
			{ 
				m_Music = PlayerPrefs.GetFloat("Music");
				m_Sound = PlayerPrefs.GetFloat("Sound");

				int Vibration = PlayerPrefs.GetInt("Vibration");
				if(Vibration==1)
				{
					m_Vibration = true;
				}
				else
				{
					m_Vibration = false;
				}
		
				int AutoUpdate = PlayerPrefs.GetInt("AutoUpdate");
				if(AutoUpdate==1)
				{
					m_AutoUpdate = true;
				}
				else
				{
					m_AutoUpdate = false;
				}
		
				int Notifications = PlayerPrefs.GetInt("Notifications");
				if(Notifications==1)
				{
					m_Notifications = true;
				}
				else
				{
					m_Notifications = false;
				}
		
				int GraphicQuality = PlayerPrefs.GetInt("GraphicQuality"); 
				switch(GraphicQuality)
				{
					case 0: 
						m_Quality = eGraphicQuality.Low; 
						break;
					case 1: 
						m_Quality = eGraphicQuality.Medium; 
						break;
					case 2: 
						m_Quality = eGraphicQuality.High; 
						break;
				}
			}
			else
			{ 
				LoadDefault();
			}
		}
	
	#endregion // Save and Load Functions

	// ######################################################################
	// Utilitie functions
	// ######################################################################

	#region Utilitie functions

		// Set current configs to default
		public void LoadDefault()
		{
			m_Music			=	m_Music_Default;
			m_Sound			=	m_Sound_Default;
			m_Vibration		=	m_Vibration_Default;
			m_AutoUpdate	=	m_AutoUpdate_Default;
			m_Notifications	=	m_Notifications_Default;
			m_Quality		=	m_Quality_Default;
		}

	#endregion //Utilitie functions

}
