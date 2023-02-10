#version 330 core
layout (location = 0) in vec3 aPosition;
layout (location = 1) in vec4 aColor;

out vec4 colorOut;

void main()
{
    colorOut = aColor;
    gl_Position = vec4(aPosition, 1.0);
}