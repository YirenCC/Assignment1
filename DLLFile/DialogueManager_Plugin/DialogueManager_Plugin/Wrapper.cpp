#include "Wrapper.h"
#include <fstream>
#include <iostream>
#include <string>

const char* LoadFile()
{
	std::string r_text = "";
	std::string text;
	std::fstream textFile;
	textFile.open("resource/dialogue.txt");
	while (!textFile.eof())
	{
		getline(textFile, text);
		r_text += text;
	}
	textFile.close();

	return r_text.c_str();
}
