﻿' Copyright (C) 2023  Andy https://github.com/AAndyProgram
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY
Imports SCrawler.Plugin.Attributes
Namespace API.Instagram
    Friend Class EditorExchangeOptions
        <PSetting(Caption:="Get timeline", ToolTip:="Download user timeline")>
        Friend Property GetTimeline As Boolean
        <PSetting(Caption:="Get stories", ToolTip:="Download user stories")>
        Friend Property GetStories As Boolean
        <PSetting(Caption:="Get tagged posts", ToolTip:="Download user tagged posts")>
        Friend Property GetTagged As Boolean
        Friend Sub New(ByVal u As UserData)
            With u
                GetTimeline = .GetTimeline
                GetStories = .GetStories
                GetTagged = .GetTaggedData
            End With
        End Sub
        Friend Sub New(ByVal s As SiteSettings)
            With s
                GetTimeline = CBool(.GetTimeline.Value)
                GetStories = CBool(.GetStories.Value)
                GetTagged = CBool(.GetTagged.Value)
            End With
        End Sub
    End Class
End Namespace