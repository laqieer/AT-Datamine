-- このluaスクリプトは、MA_01C201_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",180,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera002 = SetTemplate("Actor002",109,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
load_image("101040320", "content_still_10104032_image", "101040320_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115104)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:こんなところでなにやってんだ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180001")

-- ▼直接出力
CloseTalkWindow()
manager.CloseupUpExclusiveCamera(Actor001)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-81,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▲直接出力

	--★★ディナタン★★:早くギネヴィアさんが元気になりますようにって<br>お願いしてたの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:そっか、だいぶ衰弱してたみてえだけど<br>休養すりゃ大丈夫だろ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180003")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:そうだよね…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180004")


	--★★ディナタン★★:ねえ、マァル<br>最近よく考えるの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180005")


	--★★マルディサント★★:なんだ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:もし私と兄さんが<br>本当の兄妹じゃなかったらって
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:そういうこと、マァルは考えたりしない？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★マルディサント★★:くっだらね<br>そんなこと考えたこともない
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180009")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★マルディサント★★:もしアタシがディーナとGSしてなくて<br>それでアタシが女でもなくて
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:別のところで出会ってたらみたいな話だ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180012")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:そっか、そうだよね…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★マルディサント★★:でも…いやなんでもない
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ディナタン★★:もし私と兄さんが兄妹じゃなかったとしても<br>過ごした時間はかわらない
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:だから兄さんは兄さんのままだから
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180016")


	--★★ディナタン★★:血の繋がりがなくてもGSしても<br>変わらない
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルディサント★★:それでディーナはいいのか？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ディナタン★★:…うん
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180019")


	--★★マルディサント★★:ディーナはオニーサンのことのが<br>本当に大事なんだな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180020")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:…うん。妹、だから
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180021")


	--★★マルディサント★★:…まだ『良い子』をサボる気はないってか？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ディナタン★★:だって…知ったところで変わらないから
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180023")

-- ▼直接出力
CloseTalkWindow()
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Sad")
play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▲直接出力
-- ▼直接出力
wait_time(1.1)
DontChangeRandomCamera(false)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:左右の目が別々にものを見てるみたいだ<br>なにもかもが二重に見える
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:どういう意味…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180027")


	--★★マルディサント★★:真実はすべてのことを――…<br>いや、やめとこ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180028")


	--★★ディナタン★★:マァル？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180029")

	change_face(Actor002,"Normal")

	--★★マルディサント★★:キラーズだからって<br>兄妹だからって
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180030")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★マルディサント★★:気持ちを押し殺してもいいことはねえよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:自分の気持ちに従ったっていいんだ<br>たとえ許されなくても
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180032")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:…自分の気持ち…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:世界中がアンタを許さなくても<br>アタシだけは許してやるよ、ディーナのこと
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_180034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ディナタン★★:…うん。ありがと
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_180035")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_IN_OUT)
PlayActionDirect(Actor002,"to Run")
wait_time(1.0)
PlayActionDirect(Actor002,"to Std_Loop")
show_image("101040320", 0.0, 0.0, 0 ,true,false) 
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:えへへ…マァル、大好き
	Talk(Actor001,"CHRNAME_DINATAN","simple","N","MA_01C201_180036")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★マルディサント★★:…そいつはどーも?
	Talk(Actor002,"CHRNAME_MALADISANT","simple","N","MA_01C201_180037")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101040320", "content_still_10104032_image", "101040320_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115104)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
