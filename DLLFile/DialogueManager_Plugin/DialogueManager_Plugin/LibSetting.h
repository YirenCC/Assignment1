#pragma once
#define DIALOGUEMANAGER_PLUGIN_EXPORTS

#ifdef DIALOGUEMANAGER_PLUGIN_EXPORTS
#define LIB_API __declspec(dllexport)
#elif DIALOGUEMANAGER_PLUGIN_IMPORTS
#define LIB_API __declspec(dllimport)
#else
#define LIB_API
#endif