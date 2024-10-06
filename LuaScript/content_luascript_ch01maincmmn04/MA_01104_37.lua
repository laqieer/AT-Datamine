-- このluaスクリプトは、MA_01104_37.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:非行少女と逢引の気分はどーだ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_370002")


	--★★マルディサント★★:アタシと一緒にいても<br>ろくなことねえだろ、アンタにさ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_370003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:あの…聞いてもいいかな
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_370004")


	--★★マルディサント★★:やだね
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_370005")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:もし…だよ？祭壇の剣に触れて<br>バルバロイと戦える素養が…なかった場合は？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_370007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:学校やめて故郷に帰れってこったろ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_370009")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ディナタン★★:故郷…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_370010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:………ワリ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_370012")


	--★★ディナタン★★:仮に儀式でキラーズ因子が開花したら<br>次はどうすればいいの？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_370013")

	change_face(Actor002,"Normal")

	--★★マルディサント★★:聞くなっつってんだろお？<br>しかもお勉強のことをさあ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_370014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")

	--★★ディナタン★★:だ、だって、まだ授業でやってないんだもん！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_370015")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:――『つがい』を探すんだよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_370016")

	change_face(Actor001,"Surprise")

	--★★ディナタン★★:『つがい』？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_370017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:学園では生徒全員がGSを目指してる<br>あ、アタシ以外の全員な？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_370018")


	--★★マルディサント★★:ＧＳってのはもちろん相手が必要な契約だ<br>その相手ってのが『つがい』
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_370020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:契約って、どうやって──
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_370021")

	open_cutin(1,1)
	on_cutin(1,Actor002,"Normal")

	--★★マルディサント★★:キズナってやつを深めるらしいぜ？<br>詳しくは知らねえけどな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","N","MA_01104_370022")


	--★★マルディサント★★:<ruby=バイブス>ギネヴィア殿下</ruby>に対する<ruby=キラーズ>侍女</ruby><br><ruby=バイブス>ガウェイン</ruby>に対する<ruby=キラーズ>ラグネルパイセン</ruby>
	Talk(Actor002,"CHRNAME_MALADISANT","speech","N","MA_01104_370023")


	--★★マルディサント★★:ＧＳを果たせばキラーズ因子の力は<br>何倍にも膨れ上がる
	Talk(Actor002,"CHRNAME_MALADISANT","speech","N","MA_01104_370025")


	--★★マルディサント★★:この化け物蔓延るブリテンじゃ<br>当然欲しい力だよな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","N","MA_01104_370026")

	close_cutin()
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:つまり…強くなれる<br>兄さんの力にも、なれる
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_370027")


	--★★マルディサント★★:…アンタら兄妹ってさ<br>仲良いよな、気持ち悪ぃくらい
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_370028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:き、気持ち悪いって…！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_370029")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:褒めてンの。別に変な意味じゃねえよ<br>そういう表現方法もあるってこと
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_370030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:………勉強になります
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_370032")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
