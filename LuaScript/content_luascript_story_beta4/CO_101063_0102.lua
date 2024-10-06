-- このluaスクリプトは、CO_101063_0102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110161_02","110161_02_h")
Include("content_adv_advsmall_110161_02","Template110161_02_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110161_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110161_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_002)
	InitializeTemplateRandomCamera110161_02()
	InitializeTemplate110161_02()
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110161)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:えーっと…あいつかなおーい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01020002")

-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow()
setup_small_camera_start()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ん、俺に用事？
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_01020004")


	--★★ノワール★★:あんたさ、大図書院で本を借りて返却してないだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:あ、まずい！そうだった！
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_01020006")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,140,0.2)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
PlayActionDirect(Actor002,"to  Std_Talk")
wait_time(0.8)
se_play("SE_ADV_CO_101063_0102_Desk_Gasagasa")
wait_time(1.5)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,180,0.2)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:返そうと思って持ってきてはいたんだけどついつい忘れちゃってさ
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_01020008")

-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ところで…クリスさん、怒ってた？
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_01020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101063_01020011","CO_101063_01020012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ぜんぜん困っている感じではあったけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キャメロット騎士学術院（男）★★:そっか、よかった
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_01020015")

-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キャメロット騎士学術院（男）★★:返却日を１日でも遅れるとものすごい剣幕で怒るんだ
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_01020016")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★キャメロット騎士学術院（男）★★:『獅子より怖い司書』の異名は伊達じゃないよ
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_01020017")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:キチンと期日どおりに返せばいい話じゃないか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01020018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:カンカンだったぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01020020")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Normal")

	--★★キャメロット騎士学術院（男）★★:うわぁ、やっぱり！『獅子より怖い司書』なんて会いたくないよ！
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_01020021")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キャメロット騎士学術院（男）★★:どうしよう、どうしよう…！？
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_01020022")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんなに怖がってるのになんで滞納しちゃったんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01020023")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★キャメロット騎士学術院（男）★★:あのさ、ひとつ相談があるんだけど…
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_01020025")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:代わりに本を返却してきてほしい…ってんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01020026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:話が早くて助かるよじゃあ、これ
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_01020027")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:今回だけだからな？次はキチンと返すんだぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01020029")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ1_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110161)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110161_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
