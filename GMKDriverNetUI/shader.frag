#version 330 core

out vec4 FragColor;
in vec4 colorOut;

void main()
{
    FragColor = colorOut;
}