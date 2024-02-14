using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using System;

namespace Assets.Scripts.PlayFab
{
    public class PlayfabTest : MonoBehaviour
    {
        private const string TitleId = "9E02F";
        private string userEmail = "mstankaitis9@gmail.com";
        private string userPassword = "passwordTest999";

        private void Start()
        {
            // Initialize PlayFab with your Title ID
            PlayFabSettings.TitleId = TitleId;

            // Call Login or Register method for testing
            LoginOrRegister();
        }

        private void LoginOrRegister()
        {
            // Check if the player has PlayFabId already saved (probably from previous session)
            try {
                LoginWithEmail(userEmail, userPassword);
            }
            catch (Exception e) {
                Debug.LogWarning("Creating new account: " + e);
                RegisterNewUser(userEmail, userPassword);
            }
        }

        private void RegisterNewUser(string email, string password)
        {
            var request = new RegisterPlayFabUserRequest
            {
                Email = email,
                Password = password,
                RequireBothUsernameAndEmail = false
            };

            PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnRegisterFailure);
        }

        private void OnRegisterSuccess(RegisterPlayFabUserResult result)
        {
            Debug.Log("Registered user successfully: " + result.PlayFabId);
            PlayerPrefs.SetString("PlayFabId", result.PlayFabId);
        }

        private void OnRegisterFailure(PlayFabError error)
        {
            Debug.LogError("Failed to register user: " + error.GenerateErrorReport());
        }

        private void LoginWithCustomID(string customId)
        {
            var request = new LoginWithCustomIDRequest
            {
                CustomId = customId,
                CreateAccount = false
            };

            PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
        }

        private void OnLoginSuccess(LoginResult result)
        {
            Debug.Log("Logged in successfully: " + result.PlayFabId);
        }

        private void OnLoginFailure(PlayFabError error)
        {
            Debug.LogError("Failed to log in: " + error.GenerateErrorReport());
        }

        private void LoginWithEmail(string email, string password)
        {
            var request = new LoginWithEmailAddressRequest
            {
                Email = userEmail,
                Password = userPassword
            };

            PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginEmailSuccess, OnLoginEmailFailure);
        }

        private void OnLoginEmailSuccess(LoginResult result)
        {
            Debug.Log("Logged in successfully: " + result.PlayFabId);
        }

        private void OnLoginEmailFailure(PlayFabError error)
        {
            //Debug.LogError("Failed to log in: " + error.GenerateErrorReport());
            throw new Exception("Failed to log in: " + error.GenerateErrorReport());
        }
    }
}