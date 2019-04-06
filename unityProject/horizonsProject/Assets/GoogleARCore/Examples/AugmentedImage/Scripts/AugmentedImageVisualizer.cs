//-----------------------------------------------------------------------
// <copyright file="AugmentedImageVisualizer.cs" company="Google">
//
// Copyright 2018 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

namespace GoogleARCore.Examples.AugmentedImage
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using GoogleARCoreInternal;
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Uses 4 frame corner objects to visualize an AugmentedImage.
    /// </summary>
    public class AugmentedImageVisualizer : MonoBehaviour
    {
        /// <summary>
        /// The AugmentedImage to visualize.
        /// </summary>
        public AugmentedImage Image;

        /// <summary>
        /// A model for the lower left corner of the frame to place when an image is detected.
        /// </summary>
        //        public GameObject FrameLowerLeft;

        /// <summary>
        /// A model for the lower right corner of the frame to place when an image is detected.
        /// </summary>
        //        public GameObject FrameLowerRight;

        /// <summary>
        /// A model for the upper left corner of the frame to place when an image is detected.
        /// </summary>
        //        public GameObject FrameUpperLeft;

        /// <summary>
        /// A model for the upper right corner of the frame to place when an image is detected.
        /// </summary>
        //        public GameObject FrameUpperRight;


        public int counter1 = 0;
        public float counter2 = 0;
        public float counter3 = 0;

        public GameObject image1;
        public GameObject image2;
        public GameObject image3;

        public Button button1;
        public Button button2;
        public Button button3;

        public AudioClip audio1;
        public AudioClip audio2;
        public AudioClip audio3;
        public AudioClip audio4;
        public AudioClip audio5;
        public AudioClip EndingPro;
        public AudioClip EndingQuo;
        public AudioClip EndingAnti;

        AudioSource audiosource;

        public int lastValSelected;

        public GameObject model1a, model2a, model2b, model2c, model3a, model3b, model3c, model4a, model4b, model4c, model5a, model5b, model5c, model6a, model6b, model6c, model7a, model7b, model7c, model8a, model8b, model8c;


        void Start()
        {
            button1.onClick.AddListener(TaskOnClick1);
            button2.onClick.AddListener(TaskOnClick2);
            button3.onClick.AddListener(TaskOnClick3);

            audiosource = GetComponent<AudioSource>();
        }

        /// <summary>
        /// The Unity Update method.
        /// </summary>
        public void Update()
        {

            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                model1a.SetActive(false);

                model2a.SetActive(false);
                model2b.SetActive(false);
                model2c.SetActive(false);

                model3a.SetActive(false);
                model3b.SetActive(false);
                model3c.SetActive(false);

                model4a.SetActive(false);
                model4b.SetActive(false);
                model4c.SetActive(false);

                model5a.SetActive(false);
                model5b.SetActive(false);
                model5c.SetActive(false);

                model6a.SetActive(false);
                model6b.SetActive(false);
                model6c.SetActive(false);

                model7a.SetActive(false);
                model7b.SetActive(false);
                model7c.SetActive(false);

                model8a.SetActive(false);
                model8b.SetActive(false);
                model8c.SetActive(false);

                image1.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(false);

                return;
            }

            if (Image.Name == "001.jpg")
            {
                model2a.SetActive(false);
                model2b.SetActive(false);
                model2c.SetActive(false);

                model3a.SetActive(false);
                model3b.SetActive(false);
                model3c.SetActive(false);

                model4a.SetActive(false);
                model4b.SetActive(false);
                model4c.SetActive(false);

                model5a.SetActive(false);
                model5b.SetActive(false);
                model5c.SetActive(false);

                model6a.SetActive(false);
                model6b.SetActive(false);
                model6c.SetActive(false);

                model7a.SetActive(false);
                model7b.SetActive(false);
                model7c.SetActive(false);

                model8a.SetActive(false);
                model8b.SetActive(false);
                model8c.SetActive(false);

                // set which model 1 is true based on canvas input
                // HERE
                audiosource.PlayOneShot(audio1, 1);

                model1a.SetActive(true);
                image1.SetActive(true);
                image2.SetActive(true);
                image3.SetActive(true);

                // trigger audio

                return;

            }
            if (Image.Name == "002.jpg")
            {

                image1.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(false);

                model1a.SetActive(false);

                model3a.SetActive(false);
                model3b.SetActive(false);
                model3c.SetActive(false);

                model4a.SetActive(false);
                model4b.SetActive(false);
                model4c.SetActive(false);

                model5a.SetActive(false);
                model5b.SetActive(false);
                model5c.SetActive(false);

                model6a.SetActive(false);
                model6b.SetActive(false);
                model6c.SetActive(false);

                model7a.SetActive(false);
                model7b.SetActive(false);
                model7c.SetActive(false);

                model8a.SetActive(false);
                model8b.SetActive(false);
                model8c.SetActive(false);

                // set which model 2 is true based on canvas input
                // HERE

                audiosource.PlayOneShot(audio2, 1);


                if (lastValSelected == 1)
                {
                    model2a.SetActive(true);
                }
                else if (lastValSelected == 2)
                {
                    model2b.SetActive(true);
                }
                else if (lastValSelected == 3)
                {
                    model2c.SetActive(true);
                }

                // trigger audio

                return;
            }
            if (Image.Name == "003.jpg")
            {
                model1a.SetActive(false);

                model2a.SetActive(false);
                model2b.SetActive(false);
                model2c.SetActive(false);

                model4a.SetActive(false);
                model4b.SetActive(false);
                model4c.SetActive(false);

                model5a.SetActive(false);
                model5b.SetActive(false);
                model5c.SetActive(false);

                model6a.SetActive(false);
                model6b.SetActive(false);
                model6c.SetActive(false);

                model7a.SetActive(false);
                model7b.SetActive(false);
                model7c.SetActive(false);

                model8a.SetActive(false);
                model8b.SetActive(false);
                model8c.SetActive(false);

                // Set which model 3 is true based on canvas input
                // HERE
                audiosource.PlayOneShot(audio3, 1);


                if (lastValSelected == 1)
                {
                    model3a.SetActive(true);
                }
                else if (lastValSelected == 2)
                {
                    model3b.SetActive(true);
                }
                else if (lastValSelected == 3)
                {
                    model3c.SetActive(true);
                }

                // trigger audio


                return;
            }

            if (Image.Name == "004.jpg")
            {
                model1a.SetActive(false);

                model2a.SetActive(false);
                model2b.SetActive(false);
                model2c.SetActive(false);

                model3a.SetActive(false);
                model3b.SetActive(false);
                model3c.SetActive(false);

                model5a.SetActive(false);
                model5b.SetActive(false);
                model5c.SetActive(false);

                model6a.SetActive(false);
                model6b.SetActive(false);
                model6c.SetActive(false);

                model7a.SetActive(false);
                model7b.SetActive(false);
                model7c.SetActive(false);

                model8a.SetActive(false);
                model8b.SetActive(false);
                model8c.SetActive(false);

                // set which model 4 is true based on canvas
                // HERE
                audiosource.PlayOneShot(audio4, 1);


                if (lastValSelected == 1)
                {
                    model4a.SetActive(true);
                }
                else if (lastValSelected == 2)
                {
                    model4b.SetActive(true);
                }
                else if (lastValSelected == 3)
                {
                    model4c.SetActive(true);
                }

                // trigger audio


                return;
            }
            if (Image.Name == "004.jpg")
            {
                model1a.SetActive(false);

                model2a.SetActive(false);
                model2b.SetActive(false);
                model2c.SetActive(false);

                model3a.SetActive(false);
                model3b.SetActive(false);
                model3c.SetActive(false);

                model4a.SetActive(false);
                model4b.SetActive(false);
                model4c.SetActive(false);

                model6a.SetActive(false);
                model6b.SetActive(false);
                model6c.SetActive(false);

                model7a.SetActive(false);
                model7b.SetActive(false);
                model7c.SetActive(false);

                model8a.SetActive(false);
                model8b.SetActive(false);
                model8c.SetActive(false);

                // set which model 5 is true based on canvas
                // HERE
                audiosource.PlayOneShot(audio5, 1);


                if (lastValSelected == 1)
                {
                    model5a.SetActive(true);
                }
                else if (lastValSelected == 2)
                {
                    model5b.SetActive(true);
                }
                else if (lastValSelected == 3)
                {
                    model5c.SetActive(true);
                }

                // trigger audio


                return;
            }
            if (Image.Name == "005.jpg")
            {
                model1a.SetActive(false);

                model2a.SetActive(false);
                model2b.SetActive(false);
                model2c.SetActive(false);

                model3a.SetActive(false);
                model3b.SetActive(false);
                model3c.SetActive(false);

                model4a.SetActive(false);
                model4b.SetActive(false);
                model4c.SetActive(false);

                model5a.SetActive(false);
                model5b.SetActive(false);
                model5c.SetActive(false);

                model7a.SetActive(false);
                model7b.SetActive(false);
                model7c.SetActive(false);

                model8a.SetActive(false);
                model8b.SetActive(false);
                model8c.SetActive(false);

                // set which model 6 is true based on canvas
                // HERE

                if (lastValSelected == 1)
                {
                    model6a.SetActive(true);
                }
                else if (lastValSelected == 2)
                {
                    model6b.SetActive(true);
                }
                else if (lastValSelected == 3)
                {
                    model6c.SetActive(true);
                }

                // trigger audio


                return;
            }
            if (Image.Name == "006")
            {
                model1a.SetActive(false);

                model2a.SetActive(false);
                model2b.SetActive(false);
                model2c.SetActive(false);

                model3a.SetActive(false);
                model3b.SetActive(false);
                model3c.SetActive(false);

                model4a.SetActive(false);
                model4b.SetActive(false);
                model4c.SetActive(false);

                model5a.SetActive(false);
                model5b.SetActive(false);
                model5c.SetActive(false);

                model6a.SetActive(false);
                model6b.SetActive(false);
                model6c.SetActive(false);

                model8a.SetActive(false);
                model8b.SetActive(false);
                model8c.SetActive(false);

                // set which model 7 is true based on canvas
                // HERE

                if (lastValSelected == 1)
                {
                    model7a.SetActive(true);
                }
                else if (lastValSelected == 2)
                {
                    model7b.SetActive(true);
                }
                else if (lastValSelected == 3)
                {
                    model7c.SetActive(true);
                }

                // trigger audio


                return;
            }
            if (Image.Name == "007")
            {
                model1a.SetActive(false);

                model2a.SetActive(false);
                model2b.SetActive(false);
                model2c.SetActive(false);

                model3a.SetActive(false);
                model3b.SetActive(false);
                model3c.SetActive(false);

                model4a.SetActive(false);
                model4b.SetActive(false);
                model4c.SetActive(false);

                model5a.SetActive(false);
                model5b.SetActive(false);
                model5c.SetActive(false);

                model6a.SetActive(false);
                model6b.SetActive(false);
                model6c.SetActive(false);

                model7a.SetActive(false);
                model7b.SetActive(false);
                model7c.SetActive(false);

                if (Mathf.Max(counter1, counter2, counter3) == counter1)
                {
                    audiosource.PlayOneShot(EndingAnti, 1);
                    model8a.SetActive(true);
                }
                else if (Mathf.Max(counter1, counter2, counter3) == counter2)
                {
                    audiosource.PlayOneShot(EndingPro, 1);
                    model8b.SetActive(true);
                }
                else if (Mathf.Max(counter1, counter2, counter3) == counter3)
                {
                    audiosource.PlayOneShot(EndingQuo, 1);
                    model8c.SetActive(true);
                }
                return;
            }


            //            float halfWidth = Image.ExtentX / 2;
            //            float halfHeight = Image.ExtentZ / 2;
            //            FrameLowerLeft.transform.localPosition =
            //                (halfWidth * Vector3.left) + (halfHeight * Vector3.back);
            //            FrameLowerRight.transform.localPosition =
            //                (halfWidth * Vector3.right) + (halfHeight * Vector3.back);
            //            FrameUpperLeft.transform.localPosition =
            //                (halfWidth * Vector3.left) + (halfHeight * Vector3.forward);
            //            FrameUpperRight.transform.localPosition =
            //                (halfWidth * Vector3.right) + (halfHeight * Vector3.forward);

            //            FrameLowerLeft.SetActive(true);
            //            FrameLowerRight.SetActive(true);
            //            FrameUpperLeft.SetActive(true);
            //            FrameUpperRight.SetActive(true);
        }

        void TaskOnClick1()
        {
            lastValSelected = 1;
            counter1 = counter1 + 1;
        }

        void TaskOnClick2()
        {
            lastValSelected = 2;
            counter2 = counter2 + 1;
        }

        void TaskOnClick3()
        {
            lastValSelected = 3;
            counter3 = counter3 + 1;
        }
    }
}
