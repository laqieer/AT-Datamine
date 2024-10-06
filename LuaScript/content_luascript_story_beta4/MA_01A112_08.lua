-- このluaスクリプトは、MA_01A112_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_02","111013_02_h")
Include("content_adv_advsmall_111013_02","Template111013_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_005)
	InitializeTemplateRandomCamera111013_02()
	InitializeTemplate111013_02()
-- ▼直接出力
set_pos(Actor001,{0.9,0,19.25})
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★モーロノエー★★:長話だったわね
	Talk(Actor002,"CHRNAME_SISTERS_1","speech","L","MA_01A112_080002")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★フレン★★:権力者は自分語りが大好きね<br>うんざりよ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_080004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★モーロノエー★★:権力者はいつでも<br>にこにこ話を聞いてくれる子が大好きよ？
	Talk(Actor002,"CHRNAME_SISTERS_1","speech","L","MA_01A112_080005")

	change_face(Actor001,"Normal")

	--★★フレン★★:それでモーロノエー？<br>私はなにをすればいいの
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_080006")

	PlayAction(Actor002,"to  Std_Worry")

	--★★モーロノエー★★:カレドニアにいるローマ人は<br>ほとんどバルバロイが喰らい尽くしたわ
	Talk(Actor002,"CHRNAME_SISTERS_1","speech","L","MA_01A112_080007")

	change_face(Actor002,"Smile")

	--★★モーロノエー★★:そろそろ…食べごろだと思うの♪
	Talk(Actor002,"CHRNAME_SISTERS_1","speech","L","MA_01A112_080008")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★モーロノエー★★:フレン、あなたは彼を<br>食べやすいようにさばいて欲しいの
	Talk(Actor002,"CHRNAME_SISTERS_1","speech","L","MA_01A112_080009")


	--★★フレン★★:頭と足、どちらから食べるつもり？
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_080010")


	--★★モーロノエー★★:丸呑みしてみたいわね
	Talk(Actor002,"CHRNAME_SISTERS_1","speech","L","MA_01A112_080011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★フレン★★:のどごし悪そうね<br>…──ルーシャスは
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_080012")

	change_face(Actor002,"Smile")

	--★★モーロノエー★★:フレン…♪いいのかしら？<br>ルーシャスくんのこと悪く言ったりして
	Talk(Actor002,"CHRNAME_SISTERS_1","speech","L","MA_01A112_080014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★フレン★★:報いを受けてもらうわ<br>ローラやラシアを狂わせた報いを
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_080016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フレン★★:…妹を救ってくれた御礼しなきゃね<br>君たちには
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_080017")

	PlayAction(Actor002,"to  Std_Talk")

	--★★モーロノエー★★:ありがたく御礼をいただいたあとには<br>たち姉妹もひとおもいに?み込んであげる♪
	Talk(Actor002,"CHRNAME_SISTERS_1","speech","L","MA_01A112_080019")


	--★★モーロノエー★★:いいのよね？それで♪<br>安心して眠れるようにしてあげれば
	Talk(Actor002,"CHRNAME_SISTERS_1","speech","L","MA_01A112_080021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★フレン★★:お願いね<br>モーロノエー
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_080022")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フレン★★:神様に愛でられても、嬉しくないのよ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_080023")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
