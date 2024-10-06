-- このluaスクリプトは、MA_01104_42.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
off_active(Actor003) -- クリスティーナ非表示
set_pos(Actor003, {-6.332, 0, 13.348})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115061)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★マルディサント★★:意外だな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420002")


	--★★マルディサント★★:あのお転婆王妃殿下なら<br>ごねそうなもんなのに
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420003")

	PlayAction(Actor002,"to  Std_Angry")

	--★★マルディサント★★:「お祭りなんていいから<br>早くキャメリアード取り戻しましょ」とかさ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420005")


	--★★マルディサント★★:あの国のなか、どうなっちまってんだろうな<br>取り戻そうにも…制圧されてずいぶんなんだろ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:どうなってんのか誰もわかんねえから<br>誰も言わねえようにしてんのかな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:マルディサント
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_420008")


	--★★マルディサント★★:まー五月祭自体？軍備を整える猶予でやる<br>戦意高揚のイベントみてえなもんなんだろうが
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420009")


	--★★ディナタン★★:マルディサント
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_420010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:一国まるごと取り戻さなきゃなんねえ<br>負けりゃ学園ごとバルバロイにパクりだ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:敗北は許されねえ<br>人も武器も足りねえなかでよくやってるよ学園は
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420012")


	--★★ディナタン★★:マルディサント、ちょっと<br>あの、読めないんだけど
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_420013")

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
on_camera(Camera002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:へえへえ<br>言うようになったね
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420014")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
on_active(Actor003) -- クリスティーナ表示
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
character_in_move_walk(Actor003,CharaPos002,1.2,0.01)
-- ▲直接出力

	--★★クリスティーナ★★:おしゃべりはほどほどに<br>マルディー？
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","MA_01104_420016")

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Normal")

	--★★マルディサント★★:なあクリスちゃん<br>頼んどいた本、返ってきてる？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:タイミングいいわね<br>ちょうど今日返却されてきたわ
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","MA_01104_420019")

	PlayAction(Actor003,"to  Std_Talk")

	--★★クリスティーナ★★:『カレドニアの猟犬ブライアン<br>その半生』
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","MA_01104_420020")

	change_face(Actor001,"Surprise")

	--★★ディナタン★★:………その本<br>どんなことが書いてあるの？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_420022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルディサント★★:面白そうな本はあらかた読んじまったからさ<br>ちょっと変わり種に挑戦って感じで
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420023")


	--★★マルディサント★★:悪名高きカレドニア<br>傭兵隊長ブライアンがこれまでやってきた…
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420024")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:卑怯な作戦だったり<br>残虐な行為が記されてんのさ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420025")


	--★★ディナタン★★:なに、それ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_420026")


	--★★マルディサント★★:ログレスの敵だろ、ブライアンって確か<br>誰が書いた本だかわかんねえけど──
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420027")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Run")
-- ▲直接出力
-- ▼直接出力
wait_time(0.06)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor001,2.99,0,7.55,2.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0, 131.4637, 0,0.2)
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0, 139.3535, 0,0.5)
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0, 131.554, 0,0.4)
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:あ…おい！待てって
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_420029")

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
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
