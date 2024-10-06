-- このluaスクリプトは、MA_01108_42.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",35,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネヴィア★★:ノワールの生まれ故郷って<br>コルベニック城から遠いの？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01108_420002")


	--★★ノワール★★:目と鼻の先とまではいかないけど<br>すぐそばだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_420003")

	change_face(Actor004,"Smile")

	--★★ディナタン★★:懐かしんでる場合じゃないかもしれないけど<br>すこし、どきどきしちゃう、かも…
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01108_420004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:…２度と帰れないと思っていたんだ<br>無理もない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_420005")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:…なんか、疎外感
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01108_420006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01108_420008","MA_01108_420009","MA_01108_420010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:あとで一緒に湖を案内するよ<br>ギネヴィア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_420012")

	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:にっしっし…♪ありがとっ<br>たのしみにしとくわ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01108_420013")

	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:でも、ジューブン懐かしんだ後でいいからね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01108_420014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:あとでひさびさにこのあたりを見てまわろう<br>ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_420016")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ディナタン★★:そうだね、兄さん<br>ぐる～～っとまわろうよ
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01108_420017")

	change_face(Actor004,"Normal")

	--★★ディナタン★★:…昔を思い出して、ね
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01108_420018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:…あとで稽古でもしないか<br>ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_420020")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:あのときみたいに<br>師匠に鍛えてもらうとするか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_420021")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:昔に戻ったみたいだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_420022")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:…あ、見えてきた<br>あそこかしら？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01108_420024")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
