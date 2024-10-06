-- このluaスクリプトは、MA_01A109_15.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115114)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
set_common_look_at(Actor001,Actor002,1.0)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.0)
-- ▲直接出力
-- ▼直接出力
        -- 背景移動回転スケール
        local bg = get_object("BG")
        set_pos(bg,{-10,0,10})

        -- 固定モブ移動回転スケール
        local pro = get_object("Pro_1101_45")
        set_pos(pro,{-10,0,10})
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:や。ノワール
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_150002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネヴィア<br>例の『お色直し』は順調なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_150003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力

	--★★ギネヴィア★★:絶賛、飾り立て中～<br>まだなにをやるかは秘密ね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_150004")


	--★★ギネヴィア★★:それでノワール？<br>あなた、お暇はあるかしら
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_150005")

	open_select_window_tag(Actor001,"Normal","MA_01A109_150007","MA_01A109_150008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もちろん付き合うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_150010")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そう言ってくれると思ったんだ<br>嬉しいな
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_150011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:断る理由なんてないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_150012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ちょっと忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_150014")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:誰かに気移りしちゃったあ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_150015")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:するわけないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_150016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ごめん、イジワル言ったね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_150017")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どこに連れて行ってくれるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_150019")

	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:もお金輪際ないお誘いよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_150020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:私のお部屋へ、きて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A109_150021")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115114)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
