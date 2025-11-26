# Practical 9.1: Ghost Artificial Intelligence

In the last lecture, you learned some techniques for creating artificial intelligence characters in Unity. In this practical, you are going to use these techniques to create an AI ghost character for the horror scene from the last practical.

By the end of this practical you will be able to:

-	Create and configure a Navigation Mesh
-	Implement a basic ‘random wandering’ AI
- Use a finite state machine to implement an AI with multiple behaviors and triggers

To get started, grab the resources you need for this practical by creating a repository in your personal GitHub account and cloning it onto the machine you're working on.

The project contains the haunted house scene from the last practical. This scene has been augmented with a ghost character (which you will implement the AI for) and a set of cherry ‘power-ups’ (which will be used as a trigger to change the behavior of the ghost’s AI).

## Task 1: Creating a Navigation Mesh

In this practical, you are going to implement the AI for the ghost character, who can be found inside the house. The first step to implementing this AI is to create a Navigation Mesh, which the character will use in order to navigate the scene.

In this task, you should create a NavMesh for the scene. This Nav Mesh should be configured so that:

- The ghost is able to enter and leave the house via the door
- The ghost can’t climb up the steepest hills in the terrain (this will give the player a slight advantage when running away from the ghost)

## Task 2: Random Wandering Ghost AI

In this task, you should test that your Navigation Mesh is working by creating a simple navigation AI for the ghost. This AI should make the ghost randomly wander around the environment.

## Task 3: Implementing the Ghost AI Finite State Machine

To complete the practical today, you should implement the more advanced ghost AI described by the finite state machine below:

<img width="328" alt="aighostfsm" src="https://user-images.githubusercontent.com/2250660/203058368-eac268ad-c2d8-4fc7-85af-8b4cc6e5bcce.png">

## Task 4: Optional Extensions

If you complete all of the above tasks before the end of the practical, or would like to continue to develop your skills in your free study time, then you should consider attempting the following tasks:

- Create a timer that shows the player how long they have successfully evaded the ghost
- Add a high score board, which records the longest time that a player has been able to evade the ghost (see https://www.youtube.com/watch?v=gjFsrVWQaQw)
- Use Unity’s instantiate function to spawn multiple ghosts in the scene (see http://docs.unity3d.com/Manual/InstantiatingPrefabs.html)
- Make an animated ghost that has multiple animations based on the different AI states
