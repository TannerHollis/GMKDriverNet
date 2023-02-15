#version 330 core

layout(location = 0) in vec2 aPosition;

layout(location = 1) in vec2 aTexCoord;

out vec2 texCoord;

uniform mat4 objectTransform;

void main(void)
{
    texCoord = aTexCoord;

    gl_Position = vec4(aPosition.x, aPosition.y, 0.0, 1.0) * objectTransform;
}