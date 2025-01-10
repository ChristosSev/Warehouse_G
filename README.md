# Intro
The warehouse environment presented can be used for traversability estimation/anomaly detection experiments while executing the agent is executing an inspection task. It offers many capabilities for increasing its complexity. For instance, objects of different color might exhibit different physical properties and thus traversability estimation should rely on successful detection.


# Demo execution
Install ROS1, http://wiki.ros.org/noetic/Installation<br />
Install Unity, https://unity3d.com/get-unity/download <br />
Download Unity Hub https://unity3d.com/get-unity/download<br />
Open the Unity Hub File<br />
Find the URL of the Unity Editor version 2020.1.0f1    https://unity.com/releases/2020-1<br />
Open a new Terminal window<br />
Run './Unity-Hub-imp<url_Unity_Editor><br />
Open Unity.Hub file<br />
Clone this repo<br />
Open this repo as a project in Unity <br />
Download ROS#, https://github.com/siemens/ros-sharp<br />
Import ROS# to Unity<br />
Executing a ROS Master<br />
Open the file `Assets/NAOUM.Unity` <br />
For RosBridge:<br />
Establish the connection between Unity and ROS, https://www.youtube.com/watch?v=OZiAJuWh6w8<br />
Replace the project's 'Rosharp' folder with the one from the official Rosharp repo<br />
Once the connection is established, press the 'Play' button on Unity<br />
You can now move the robot around the Unity environment, collected screenshots as input images and see robot's sensor topics in ROS.<br />

