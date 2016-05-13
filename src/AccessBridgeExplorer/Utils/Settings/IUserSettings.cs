// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.IO;

namespace AccessBridgeExplorer.Utils.Settings {
  public interface IUserSettings {
    event EventHandler<ErrorEventArgs> Error;
    event EventHandler Loaded;
    event EventHandler Saving;

    void SetValue(string key, string value);
    void SetIntValue(string key, int value);
    void SetBoolValue(string key, bool value);

    string GetValue(string key, string defaultValue);
    int GetIntValue(string key, int defaultValue);
    bool GetBoolValue(string key, bool defaultValue);

    void Remove(string key);

    void Load();
    void Save();
  }
}