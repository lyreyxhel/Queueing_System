#include "pch.h"         // ✅ Required if precompiled headers are enabled
#include <ctime>
#include <cstdlib>

extern "C" __declspec(dllexport) int GenerateQueueNumber() {
    srand((unsigned)time(0));
    return 1000 + rand() % 9000;
}
