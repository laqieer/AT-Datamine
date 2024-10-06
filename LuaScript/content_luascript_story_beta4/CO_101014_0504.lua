-- このluaスクリプトは、CO_101014_0504.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	Camera002 = SetTemplate("Actor002",305,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor002)
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.2} , 1)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:ねえ<br>なんの話だったの？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_05040002")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うわ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05040003")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.7, 0.2} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あ、ああ、トリスタンか…えーっとだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05040004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:話しにくいなら<br>無理に話さなくてもいいよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_05040005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:ただ、ちょっと他に聞きたいことがある
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_05040006")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだ？<br>あらたまって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05040007")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:最近のイゾルデは…ボクとキミが<br>関わることはいいことだと思ってるみたいなんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_05040008")

	PlayAction(Actor002,"to  Std_Worry")

	--★★トリスタン★★:ボクがキミの愚痴を言ってると<br>なぜか機嫌がいいんだよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_05040009")

-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ねえ、キミはなんでだと思う？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_05040010")

	open_select_window_tag(Actor001,"Normal","CO_101014_05040012","CO_101014_05040013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんでって言われてもな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05040015")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:これは、あくまで俺の想像だけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05040016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:イゾルデなりに<br>お前のことを心配してるんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05040017")

	change_face(Actor002,"Surprise")

	--★★トリスタン★★:心配？なんでそんな…<br>それに言いたいことがあるなら言えばいいのに
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_05040019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それより<br>イゾルデに俺の愚痴を聞かせてるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05040021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:うん<br>できればキミと関わり合いになりたくないってね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_05040022")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:本人を前に<br>それを言えるってすごいな、お前…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05040023")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ともかくさ<br>身近すぎるからこそ言えないこともあるだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05040025")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★トリスタン★★:身近すぎるからこそ言えないこと？<br>よくわからないけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_05040026")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:参考程度に覚えておくよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_05040028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ<br>ぜひ、そうしてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05040030")

-- ▼直接出力
local trustParam = set_communication_rankup("トリスタン_コミュランク", "トリスタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
