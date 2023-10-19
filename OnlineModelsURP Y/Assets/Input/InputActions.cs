// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""96c4f1b7-3055-41b6-8986-5f8b48b81f15"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""6bd89c3c-61c8-4d40-ad8f-397eca4bb67b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCam"",
                    ""type"": ""Value"",
                    ""id"": ""c5303e28-19f0-4206-8fbf-56628dd500de"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""3bb179ca-1ea7-468c-b80b-4d760d833b34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""26437bbc-b46b-4198-be9a-545474467ade"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bd6e7ff6-40f0-4c0e-b3c7-8f5b9ba231e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""b122bf63-46a9-4d7f-bb99-fa7b5cff9681"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""b03a43f5-5303-453d-981a-8c0686f4f1eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""06260b60-9f5c-4c2e-8d94-493a02517a15"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""fe687018-20ad-4ea8-94de-e6de7f1ef1d2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""38f6978d-d725-4215-8ebf-2c6e8b8efece"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5f1c0eff-0b3b-43d6-9779-0049fefead72"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""49c06460-ab93-4a4a-aabe-4cd60a38758d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""899b80fa-8907-418d-9dc0-22b28709f2d7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""92c4d78b-9ede-48ad-b29a-50e417457994"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eedbe67d-ddd4-461f-84c2-e75be2c4bf0f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e628ecfe-5f4c-48e2-a307-ad6a581858d8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ff581fbe-844e-4073-bce7-940012b6d7c6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""be65c8a4-2436-4197-8c17-76e909865cc7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""18ddb2a1-2f4f-474a-9fb0-ba7b09c25505"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""725e092b-2413-45dd-9cea-6d8260250a82"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""969d3ff9-ca03-4e29-aa9a-1f29e6f55fda"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12bf08d8-81cb-47c1-bd30-6b6a825297f7"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fc0fe80-7140-4c6a-ab98-d00bc0f1c46f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1450da17-019e-4894-882a-0ea45a0df502"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab2789e0-ae22-4b31-8da6-b11e5c710699"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1ed0e10-9e79-4510-bdd5-7a1b84180293"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbb520f8-1741-4cf8-9e5d-bcdc84d57c00"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b197e536-882f-4324-b77e-ece5962ee845"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""659a31a9-817d-4d36-b3ad-f1ee5e933e86"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PopUp"",
            ""id"": ""928ae0f8-dfbc-4771-89d9-76f7a8785385"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""44c036e7-51f1-43cc-a73f-ab9d56e01939"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""9bd2c74f-05d6-4edd-a2d6-3154c643be78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0e269b03-7493-43f8-9a6e-d802053826a4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c271be8-56d1-4ede-ae8f-39f9e9a8e081"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0957597f-3b9d-430a-b953-d546cd83fa57"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd4789d5-1bf0-4ae7-9c45-0a683a479a4e"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""KeyBoard"",
            ""id"": ""d22e09a8-7776-4b57-9237-e0eb1eccbb8f"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""716a515e-9625-49d8-821b-1686c5b2fd31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f5c086f0-ee81-46b1-a022-7f2c80664dd7"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PauseScreen"",
            ""id"": ""2a101b07-f844-4967-9b8f-af3d015962e4"",
            ""actions"": [
                {
                    ""name"": ""RBumper"",
                    ""type"": ""Button"",
                    ""id"": ""6c0111bb-24e1-4c79-bbf0-ed09a1dffb6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LBumper"",
                    ""type"": ""Button"",
                    ""id"": ""a298aae9-70e4-431f-8ac5-30c89c46eb5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""23db760a-10bd-4fe1-8ebc-10227e47f364"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""c93f3017-5fe5-4ec8-9a5e-876f465aea9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""428df18c-c021-4224-86ef-1f4aad076996"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UnPause"",
                    ""type"": ""Button"",
                    ""id"": ""4e2b6d49-0d42-4b2c-9708-e1a18547bcaa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2401bf75-199f-4850-a47a-6766d5b8ef12"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RBumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""249032e0-0158-473c-89d1-1330a8282e38"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RBumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5227e6a0-7350-4a4d-8c8f-ce3a132d15d8"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LBumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e0dffce-ce81-4ddd-9e42-7a19999be8f6"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LBumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""618b94c9-acd8-4e3b-bab3-77363b75c5c6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""MoveSelect"",
                    ""id"": ""3719e228-391d-47c2-a7ea-c8177d7a6a1a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d4ffd3be-8662-4d6c-91dd-814262f830c9"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5290a8e6-466e-4f65-9a7a-cbb4908e3569"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""54269a48-5161-4630-b0ab-9e24c505ffd9"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0b2343de-6b72-4749-9025-41aa02f15708"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""9f04fb90-b334-4666-a913-813c3073b97e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b15a192d-250a-43d1-9eff-e60a917442d3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5279bc98-6472-4323-b6b8-db9d5c33134b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c21907c4-f884-4d71-89a0-2763ad9c070d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c50ea91b-40e4-4b3f-865d-0fd6ef2ae856"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e582cbb-4744-48b7-b40f-67466af73444"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d99fa0d-2fab-4f6d-a076-97c19babbf74"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b2e67e1-60b9-4cab-b0b9-c71da9b23f8c"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6dbb59a-62bf-4915-a441-9ed004e1230f"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UnPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c2338df-efe8-4496-a52e-ef56fbbf220e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UnPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Walk = m_Main.FindAction("Walk", throwIfNotFound: true);
        m_Main_MoveCam = m_Main.FindAction("MoveCam", throwIfNotFound: true);
        m_Main_Shoot = m_Main.FindAction("Shoot", throwIfNotFound: true);
        m_Main_Pause = m_Main.FindAction("Pause", throwIfNotFound: true);
        m_Main_Jump = m_Main.FindAction("Jump", throwIfNotFound: true);
        m_Main_LSwitch = m_Main.FindAction("LSwitch", throwIfNotFound: true);
        m_Main_RSwitch = m_Main.FindAction("RSwitch", throwIfNotFound: true);
        // PopUp
        m_PopUp = asset.FindActionMap("PopUp", throwIfNotFound: true);
        m_PopUp_Select = m_PopUp.FindAction("Select", throwIfNotFound: true);
        m_PopUp_Back = m_PopUp.FindAction("Back", throwIfNotFound: true);
        // KeyBoard
        m_KeyBoard = asset.FindActionMap("KeyBoard", throwIfNotFound: true);
        m_KeyBoard_Newaction = m_KeyBoard.FindAction("New action", throwIfNotFound: true);
        // PauseScreen
        m_PauseScreen = asset.FindActionMap("PauseScreen", throwIfNotFound: true);
        m_PauseScreen_RBumper = m_PauseScreen.FindAction("RBumper", throwIfNotFound: true);
        m_PauseScreen_LBumper = m_PauseScreen.FindAction("LBumper", throwIfNotFound: true);
        m_PauseScreen_Move = m_PauseScreen.FindAction("Move", throwIfNotFound: true);
        m_PauseScreen_Select = m_PauseScreen.FindAction("Select", throwIfNotFound: true);
        m_PauseScreen_Back = m_PauseScreen.FindAction("Back", throwIfNotFound: true);
        m_PauseScreen_UnPause = m_PauseScreen.FindAction("UnPause", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_Walk;
    private readonly InputAction m_Main_MoveCam;
    private readonly InputAction m_Main_Shoot;
    private readonly InputAction m_Main_Pause;
    private readonly InputAction m_Main_Jump;
    private readonly InputAction m_Main_LSwitch;
    private readonly InputAction m_Main_RSwitch;
    public struct MainActions
    {
        private @InputActions m_Wrapper;
        public MainActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Main_Walk;
        public InputAction @MoveCam => m_Wrapper.m_Main_MoveCam;
        public InputAction @Shoot => m_Wrapper.m_Main_Shoot;
        public InputAction @Pause => m_Wrapper.m_Main_Pause;
        public InputAction @Jump => m_Wrapper.m_Main_Jump;
        public InputAction @LSwitch => m_Wrapper.m_Main_LSwitch;
        public InputAction @RSwitch => m_Wrapper.m_Main_RSwitch;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_MainActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnWalk;
                @MoveCam.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMoveCam;
                @MoveCam.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMoveCam;
                @MoveCam.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMoveCam;
                @Shoot.started -= m_Wrapper.m_MainActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnShoot;
                @Pause.started -= m_Wrapper.m_MainActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnPause;
                @Jump.started -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @LSwitch.started -= m_Wrapper.m_MainActionsCallbackInterface.OnLSwitch;
                @LSwitch.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnLSwitch;
                @LSwitch.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnLSwitch;
                @RSwitch.started -= m_Wrapper.m_MainActionsCallbackInterface.OnRSwitch;
                @RSwitch.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnRSwitch;
                @RSwitch.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnRSwitch;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @MoveCam.started += instance.OnMoveCam;
                @MoveCam.performed += instance.OnMoveCam;
                @MoveCam.canceled += instance.OnMoveCam;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @LSwitch.started += instance.OnLSwitch;
                @LSwitch.performed += instance.OnLSwitch;
                @LSwitch.canceled += instance.OnLSwitch;
                @RSwitch.started += instance.OnRSwitch;
                @RSwitch.performed += instance.OnRSwitch;
                @RSwitch.canceled += instance.OnRSwitch;
            }
        }
    }
    public MainActions @Main => new MainActions(this);

    // PopUp
    private readonly InputActionMap m_PopUp;
    private IPopUpActions m_PopUpActionsCallbackInterface;
    private readonly InputAction m_PopUp_Select;
    private readonly InputAction m_PopUp_Back;
    public struct PopUpActions
    {
        private @InputActions m_Wrapper;
        public PopUpActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_PopUp_Select;
        public InputAction @Back => m_Wrapper.m_PopUp_Back;
        public InputActionMap Get() { return m_Wrapper.m_PopUp; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PopUpActions set) { return set.Get(); }
        public void SetCallbacks(IPopUpActions instance)
        {
            if (m_Wrapper.m_PopUpActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_PopUpActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PopUpActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PopUpActionsCallbackInterface.OnSelect;
                @Back.started -= m_Wrapper.m_PopUpActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_PopUpActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_PopUpActionsCallbackInterface.OnBack;
            }
            m_Wrapper.m_PopUpActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }
        }
    }
    public PopUpActions @PopUp => new PopUpActions(this);

    // KeyBoard
    private readonly InputActionMap m_KeyBoard;
    private IKeyBoardActions m_KeyBoardActionsCallbackInterface;
    private readonly InputAction m_KeyBoard_Newaction;
    public struct KeyBoardActions
    {
        private @InputActions m_Wrapper;
        public KeyBoardActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_KeyBoard_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_KeyBoard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyBoardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyBoardActions instance)
        {
            if (m_Wrapper.m_KeyBoardActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_KeyBoardActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_KeyBoardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public KeyBoardActions @KeyBoard => new KeyBoardActions(this);

    // PauseScreen
    private readonly InputActionMap m_PauseScreen;
    private IPauseScreenActions m_PauseScreenActionsCallbackInterface;
    private readonly InputAction m_PauseScreen_RBumper;
    private readonly InputAction m_PauseScreen_LBumper;
    private readonly InputAction m_PauseScreen_Move;
    private readonly InputAction m_PauseScreen_Select;
    private readonly InputAction m_PauseScreen_Back;
    private readonly InputAction m_PauseScreen_UnPause;
    public struct PauseScreenActions
    {
        private @InputActions m_Wrapper;
        public PauseScreenActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RBumper => m_Wrapper.m_PauseScreen_RBumper;
        public InputAction @LBumper => m_Wrapper.m_PauseScreen_LBumper;
        public InputAction @Move => m_Wrapper.m_PauseScreen_Move;
        public InputAction @Select => m_Wrapper.m_PauseScreen_Select;
        public InputAction @Back => m_Wrapper.m_PauseScreen_Back;
        public InputAction @UnPause => m_Wrapper.m_PauseScreen_UnPause;
        public InputActionMap Get() { return m_Wrapper.m_PauseScreen; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseScreenActions set) { return set.Get(); }
        public void SetCallbacks(IPauseScreenActions instance)
        {
            if (m_Wrapper.m_PauseScreenActionsCallbackInterface != null)
            {
                @RBumper.started -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnRBumper;
                @RBumper.performed -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnRBumper;
                @RBumper.canceled -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnRBumper;
                @LBumper.started -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnLBumper;
                @LBumper.performed -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnLBumper;
                @LBumper.canceled -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnLBumper;
                @Move.started -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnMove;
                @Select.started -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnSelect;
                @Back.started -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnBack;
                @UnPause.started -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnUnPause;
                @UnPause.performed -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnUnPause;
                @UnPause.canceled -= m_Wrapper.m_PauseScreenActionsCallbackInterface.OnUnPause;
            }
            m_Wrapper.m_PauseScreenActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RBumper.started += instance.OnRBumper;
                @RBumper.performed += instance.OnRBumper;
                @RBumper.canceled += instance.OnRBumper;
                @LBumper.started += instance.OnLBumper;
                @LBumper.performed += instance.OnLBumper;
                @LBumper.canceled += instance.OnLBumper;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @UnPause.started += instance.OnUnPause;
                @UnPause.performed += instance.OnUnPause;
                @UnPause.canceled += instance.OnUnPause;
            }
        }
    }
    public PauseScreenActions @PauseScreen => new PauseScreenActions(this);
    public interface IMainActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnMoveCam(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLSwitch(InputAction.CallbackContext context);
        void OnRSwitch(InputAction.CallbackContext context);
    }
    public interface IPopUpActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
    public interface IKeyBoardActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IPauseScreenActions
    {
        void OnRBumper(InputAction.CallbackContext context);
        void OnLBumper(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnUnPause(InputAction.CallbackContext context);
    }
}
