-- このluaスクリプトは、MA_01C112_33.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_004)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002, 0)
turn_lookat(Actor002,Actor001, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115040)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")

	--★★ディナタン★★:ねえ、兄さん。ちょっといいかな？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_330002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:食堂でガレスさんがクリスマスのメニューを<br>作ってるんだけど、材料が足りないんだって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_330003")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ディナタン★★:でね、リオネスも手伝いで忙しそうだから<br>私が代わりにおつかいに行こうと思ってて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_330004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C112_330005","MA_01C112_330006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ノワール★★:荷物持ちってわけか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_330008")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ディナタン★★:さっすが兄さん、話が早い！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_330009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:ディナタンの言いたいことくらいわかるよ<br>何年の付き合いだと思ってるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_330010")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:えへへ<br>それじゃ、さっそくマーケットまで行こう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_330011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:クリスマスを盛り上げるため、か…<br>ガレスはすごいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_330013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:うん。今の自分にできることを<br>やりたいんだって言ってた
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_330014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:すごいよね<br>だから…私も手伝いたくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_330015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:わかった。俺も付き合うよ<br>荷物持ちくらいならな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_330016")

	goto Block1end

::Block1end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115040)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 1
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
