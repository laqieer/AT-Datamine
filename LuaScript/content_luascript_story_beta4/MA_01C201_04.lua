-- このluaスクリプトは、MA_01C201_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-79,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	Camera002 = SetTemplate("Actor002",62,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115160)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:本当なら、一年の始まりは毎年<br>コーンウォールへ行くんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_040002")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★トリスタン★★:イゾルデとふたりで海を見てさ<br>水平線から昇る太陽を眺めて
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:きっとすごく綺麗だろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_040004")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力

	--★★トリスタン★★:本当なら教えたくないくらいにはね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_040005")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:じゃあ、なんで教えてくれるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_040006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:自分で考えてよ、それくらい
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_040007")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:機会があれば、キミも一緒に<br>連れて行ってあげてもいいよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_040009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C201_040010","MA_01C201_040011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それは楽しみだ<br>せっかくの誘いだし、ぜひお願いするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_040013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:わかった<br>イゾルデには許可をもらっておくよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_040014")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:じゃあ…来年、行こうか
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_040015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ふたりの邪魔になるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_040017")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:いいよ。キミなら
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_040018")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:今回はそういう雰囲気でもないけど<br>ほら…来年にでもさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_040019")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:来年…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_040021")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:そのときまでには少しくらい<br>マシな顔になっててよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_040022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:今すぐにとは言わないからさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C201_040023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…あぁ?
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_040024")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115160)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 1
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
