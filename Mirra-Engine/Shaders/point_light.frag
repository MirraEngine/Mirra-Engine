#version 330 core

struct Material 
{
	sampler2D diffuse;
	sampler2D specular;
	float shine;
};

struct Light 
{
	vec3 position; 	

	vec3 ambient;
	vec3 diffuse;
	vec3 specular;

	float constant;
	float linear;
	float quadratic;
};

uniform Light light;
uniform Material material;
uniform vec3 viewPosition;

out vec4 FragColor;

in vec3 Normal;
in vec3 FragPosition;

in vec2 TexCoords;

void main()
{
	// ambient
	vec3 ambient = light.ambient * vec3(texture(material.diffuse, TexCoords));
	
	// diffuse
	vec3 norm = normalize(Normal);
	vec3 lightDir = normalize(-light.position - FragPosition);
	float diff = max(dot(norm, lightDir), 0.0);
	vec3 diffuse = light.diffuse * diff * vec3(texture(material.diffuse, TexCoords));

	// specular
	vec3 viewDir = normalize(viewPosition - FragPosition);
	vec3 reflectionDir = reflect(-lightDir , norm);
	float spec = pow(max(dot(viewDir, reflectionDir), 0.0), material.shine);
	vec3 specular = light.specular * spec * vec3(texture(material.specular, TexCoords));

	// attenuation
	float distance = length(light.position - FragPosition);
	float attenuation = 1.0/(light.constant + light.linear * distance + light.quadratic * (distance * distance));

	ambient *= attenuation;
	diffuse *= attenuation;
	specular *= attenuation;


	vec3 result = ambient + diffuse + specular;

	FragColor = vec4(result, 1.0);
}