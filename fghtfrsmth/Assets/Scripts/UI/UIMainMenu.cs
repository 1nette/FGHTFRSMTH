using UnityEngine;
using UnityEngine.Rendering;

namespace UI
{
    public class UIMainMenu : MonoBehaviour
    {
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private GameObject newGamePanel;
        [SerializeField] private GameObject loadGamePanel;
        
        public void NewGameOnClick()
        {
            menuPanel.SetActive(false);
            newGamePanel.SetActive(true);
        }
        
        public void LoadGameOnClick()
        {
            menuPanel.SetActive(false);
            loadGamePanel.SetActive(true);
        }
        
        public void BackOnClick()
        {
            newGamePanel.SetActive(false);
            loadGamePanel.SetActive(false);
            menuPanel.SetActive(true);
        }
        
        public void ExitOnClick()
        {
            
        }
    }
}
