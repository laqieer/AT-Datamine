-- このluaスクリプトは、CO_101035_0603.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_rot(Actor003,{0,55,0})
karedo = setup_prop_object(10130003)
set_pos(karedo,{12,0,2.8})
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あれは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06030002")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera008)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:人が倒れています！助けてあげないと！！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030003")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_No")
turn_chara(Actor001,125,0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:待て！あの鎧…カレドニア兵士のものだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06030005")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
turn_chara(Actor003,-55,0.5)
set_enable_auto_lookat(Actor001,true)
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:どうやらまだ息はあるようだけど…<br>どうするの？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_06030006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★リリアーナ★★:助けましょう！私は助けてあげたい…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030007")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101035_06030009","CO_101035_06030010","CO_101035_06030011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:見捨てるというわけではないけど助けるのは、ちょっと気が進まないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06030013")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Surp")
turn_chara(Actor002,25,0.3)
PlayPartVoice("リリアーナ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:そんな…！ひどいです、ノワールさん
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030014")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:リリアーナの気持ちはわかるよでも、敵兵だし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06030015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★リリアーナ★★:私は行きます！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:賛成だ。カレドニア兵とはいえ傷ついている人間を放っておくわけにはいかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06030018")

-- ▼直接出力
turn_chara(Actor002,25,0)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:甘いのねあなたも、リリアーナも
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_06030019")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:よく言われるよ、昔から
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06030020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:ありがとうございます、ノワールさん急ぎましょう、手遅れになってしまう前に
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030021")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺が様子を見てくるリリアーナとクレアはここにいてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06030023")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:わたしは大丈夫よついていくわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_06030024")

	change_face(Actor001,"Normal")

	--★★ノワール★★:万が一のことがあるリリアーナを守ってやってくれ、クレア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06030025")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:そういうことなら
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_06030026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★リリアーナ★★:おふたりともありがとうございますでも、私のことなら心配いりません！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030027")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Camera001=setup_small_camera_resetting(Actor001,CharaPos008,CameraPos008)
PlayActionDirect(Actor001,"to Std_Loop")
set_rot(Actor001,{0,65,0})
change_face(Actor001,"Normal")
set_pos(Actor002,{-0.7,0,0.5})
set_rot(Actor002,{0,-140,0})
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Kneeling")
Camera003=setup_small_camera_resetting(Actor003,CharaPos003,CameraPos003)
PlayActionDirect(Actor003,"to Std_Loop")
set_pos(karedo,{-1.25,0.1,0.2})
set_rot(karedo,{0,155,0})
set_common_look_at(Actor001,karedo)
set_common_look_at(Actor002,karedo)
set_common_look_at(Actor003,karedo)
set_enable_auto_lookat_all(false)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:熱がある…呼吸もかなり乱れていますね…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030029")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:このままここに放っておいたら危ないわね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_06030030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(true)
PlayPartVoice("リリアーナ", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★リリアーナ★★:うっ、う～ん！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030032")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おい、リリアーナ<br>なにをするつもりなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06030033")

-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力

	--★★リリアーナ★★:この近くに洞窟があったはずですいったんそこに避難させてあげようと思って
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030034")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クレア★★:でも、その人は…
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_06030035")

-- ▼直接出力
CameraEX = set_camera({-0.73,0.5,-1.2,-5,0,0,14})
setup_small_camera_start(CameraEX)
on_active(FX_DoF)
slidemove(CameraEX,{-0.7,0.5,-1.2},7.0)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★リリアーナ★★:敵だとか味方だとか、そんなの関係ありません！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030036")

	change_face(Actor002,"Anger")

	--★★リリアーナ★★:私たちが今やっつけなきゃならないのはバルバロイのはずです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030037")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:人間同士で争いあうなんて、おかしいです！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_06030038")

-- ▼直接出力
setup_small_camera_start()
off_active(FX_DoF)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺が運ぶよ<br>ふたりはこの人の荷物を頼む
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_06030040")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リリアーナ_ランクアップ6_4")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
setup_prop_object_preload(10130003)
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
