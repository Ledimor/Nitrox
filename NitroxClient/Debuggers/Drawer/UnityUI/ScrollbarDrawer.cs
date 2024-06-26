﻿using UnityEngine;
using UnityEngine.UI;

namespace NitroxClient.Debuggers.Drawer.UnityUI;

public class ScrollbarDrawer : IDrawer<Scrollbar>
{
    private readonly SceneDebugger sceneDebugger;
    private readonly SelectableDrawer selectableDrawer;

    public ScrollbarDrawer(SceneDebugger sceneDebugger, SelectableDrawer selectableDrawer)
    {
        this.sceneDebugger = sceneDebugger;
        this.selectableDrawer = selectableDrawer;
    }

    public void Draw(Scrollbar scrollbar)
    {
        selectableDrawer.Draw(scrollbar);

        GUILayout.Space(10);

        using (new GUILayout.HorizontalScope())
        {
            GUILayout.Label("Handle Rect", NitroxGUILayout.DrawerLabel, GUILayout.Width(NitroxGUILayout.DEFAULT_LABEL_WIDTH));
            NitroxGUILayout.Separator();
            if (GUILayout.Button("Jump to", GUILayout.Width(NitroxGUILayout.DEFAULT_LABEL_WIDTH)))
            {
                sceneDebugger.JumpToComponent(scrollbar.handleRect);
            }
        }

        using (new GUILayout.HorizontalScope())
        {
            GUILayout.Label("Direction", NitroxGUILayout.DrawerLabel, GUILayout.Width(NitroxGUILayout.DEFAULT_LABEL_WIDTH));
            NitroxGUILayout.Separator();
            scrollbar.direction = NitroxGUILayout.EnumPopup(scrollbar.direction);
        }

        using (new GUILayout.HorizontalScope())
        {
            GUILayout.Label("Value", NitroxGUILayout.DrawerLabel, GUILayout.Width(NitroxGUILayout.DEFAULT_LABEL_WIDTH));
            NitroxGUILayout.Separator();
            scrollbar.value = NitroxGUILayout.SliderField(scrollbar.value, 0f, 1f);
        }

        using (new GUILayout.HorizontalScope())
        {
            GUILayout.Label("Size", NitroxGUILayout.DrawerLabel, GUILayout.Width(NitroxGUILayout.DEFAULT_LABEL_WIDTH));
            NitroxGUILayout.Separator();
            scrollbar.size = NitroxGUILayout.SliderField(scrollbar.size, 0f, 1f);
        }

        using (new GUILayout.HorizontalScope())
        {
            GUILayout.Label("Number Of Steps", NitroxGUILayout.DrawerLabel, GUILayout.Width(NitroxGUILayout.DEFAULT_LABEL_WIDTH));
            NitroxGUILayout.Separator();
            scrollbar.numberOfSteps = NitroxGUILayout.SliderField(scrollbar.numberOfSteps, 0, 11);
        }

        using (new GUILayout.HorizontalScope())
        {
            GUILayout.Label("On Value Changed", NitroxGUILayout.DrawerLabel, GUILayout.Width(NitroxGUILayout.DEFAULT_LABEL_WIDTH));
            NitroxGUILayout.Separator();
            GUILayout.Button("Unsupported", GUILayout.Width(NitroxGUILayout.DEFAULT_LABEL_WIDTH));
        }
    }
}
