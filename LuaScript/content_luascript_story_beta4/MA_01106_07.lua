-- このluaスクリプトは、MA_01106_07.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",81,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115061)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:ねえ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070002")


	--★★マルディサント★★:あ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_070003")


	--★★ディナタン★★:奥、来てよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070005")


	--★★マルディサント★★:…あ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_070006")

	change_face(Actor001,"Smile")

	--★★ディナタン★★:いつかのお返し、まだだったなと…思って
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:いつのこったよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_070008")


	--★★ディナタン★★:貴方の、お芝居…見ちゃった、から
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:私も…恥ずかしいけど、見せるから
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070011")


	--★★マルディサント★★:………あんたが、歌ってるとこ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_070012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Shy")

	--★★ディナタン★★:…うん
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")

	--★★マルディサント★★:なんのつもりだよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_070014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:おせっかい
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070015")

	PlayAction(Actor002,"to  Std_No")

	--★★マルディサント★★:だろーな<br>行かねえよ、アタシ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_070016")


	--★★マルディサント★★:あそこの引き払いの手伝いなんかしたかねえ /それになんでセンソー中にリンゴ狩りなんだよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_070017")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:マルディサント
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070018")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★マルディサント★★:慰めのつもりかよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_070019")

	PlayAction(Actor001,"to  Std_No")

	--★★ディナタン★★:私のお母さんも病気がちだったの /兄さんとふたりでいつも看病してた
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:だからわかるよ /あなたが妹さんを想う気持ち
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070021")

	change_face(Actor002,"Anger")

	--★★マルディサント★★:わかったような口きくな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_070022")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:そのときにいた場所が取られちゃうツラさ /すごく、よく、わかる…気がするの、わかりたい
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")

	--★★ディナタン★★:でも、もう帰れなくなるのは /もっとツラいよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070024")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★マルディサント★★:忘れてえこともあんだよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01106_070026")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力

	--★★ディナタン★★:………それでも、無理する必要もないけど /それでも…だよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070027")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:家族がいる場所…<br>「いつも」に、帰れる場所があるなら
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_070029")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115061)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
