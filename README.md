# trrt-unity
Unity3D-based implementation of the TRRT path-planning algorithm

## Objectives
- Implement the path-planning algorithm described in the whitepaper [“Transition-based RRT for Path Planning in Continuous Cost Spaces” (Jaillet, Cortés, and Siméon, 2008)](http://www.leonardjaillet.com/Publications_files/Iros08_Jaillet_TransitRRT.pdf)
- Learn how to use the [Unity3D](https://unity3d.com/) engine

### Details
This project is based upon the whitepaper “Transition-based RRT for Path Planning in Continuous Cost Spaces” (Jaillet, Cortés, and Siméon, 2008). Their paper described a novel modification to traditional rapidly-exploring random trees (RRTs) that “combines the exploration strength of the RRT algorithm [...] with the efficiency of stochastic optimization methods”. The algorithm described therein is suitable for a broad class of problems, including high-dimensional tasks such as motion planning for a many-DOF manipulator, as well analyzing protein-ligand interactions. My task was to translate the authors’ pseudo-code into a fully-functional algorithm while also implementing a solid user interface and 3D visualization. I selected Unity3D (a popular game-development tool [1]) as my engine of choice for the latter elements.
