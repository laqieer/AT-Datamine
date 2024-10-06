-- このluaスクリプトは、MA_01106_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",78,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★イゾルデ★★:１曲、聴かせてもらえる？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030002")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:…ごめんなさい
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★イゾルデ★★:あら。芸術を無償では提供しない考え？<br>トリスタンと同じね。見上げた心がけだわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030005")

	change_face(Actor002,"Normal")

	--★★イゾルデ★★:歌で塞がる傷があれば<br>いくらでも奏でるでしょうに…難儀なものね？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030006")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ディナタン★★:…失礼します
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★イゾルデ★★:記憶が喰われる病なんですって
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030010")

	change_face(Actor001,"Surprise")

	--★★ディナタン★★:え…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_030012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★イゾルデ★★:あの非行少女の妹さん<br>お父様やお母様も同じ病だったらしいわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030013")


	--★★イゾルデ★★:『狂忘症』
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030015")


	--★★イゾルデ★★:身体が時折呼吸を忘れ、意識の保ちかたを忘れ<br>末期は断続的に昏睡状態に陥ってしまう
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★イゾルデ★★:異常な咳とともに──
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030017")


	--★★イゾルデ★★:目を覚ますたびに記憶が少しずつ薄れていき<br>しまいには目を覚まさなくなる
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★イゾルデ★★:我を忘れて<br>暴れだすケースもあるらしいわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030019")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ディナタン★★:！<br>それって…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_030020")


	--★★イゾルデ★★:記憶と身体を同時に蝕む症状<br>バルバロイにも関係ありそうだけれど
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★イゾルデ★★:どうかしらね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030022")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:どうして…私にそれを？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_030023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★イゾルデ★★:ふたつ、気をつけてほしいことがあるの
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030024")


	--★★イゾルデ★★:ひとつ目<br>お前の身近な人に気をつけて
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030025")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:誰のことですか…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_030026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★イゾルデ★★:非行少女の両親はなすすべなく病死<br>彼女の妹も救われず死亡
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030027")


	--★★イゾルデ★★:彼女自身も<br>病室へと通い詰めているわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030028")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
	close_cutin()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★イゾルデ★★:正直、憶測の域は出ないけれど<br>身構えておくに越したことはないわね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030030")


	--★★イゾルデ★★:ふたつ目<br>己の至らなさを知ることね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030032")


	--★★イゾルデ★★:お前の兄は恐らく選ばれし人<br>いずれは平和を継ぐ鍵となる人
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:え、選ばれし人…？平和を継ぐ…？<br>なにを、言ってるんですか…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_030035")


	--★★イゾルデ★★:だけど、お前は気にしないでいいの<br>お前にはなにもできないだろうから
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★イゾルデ★★:面倒事を増やされては困るのよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030037")

	change_face(Actor002,"Anger")

	--★★イゾルデ★★:もし仮にお前が兄に選ばれれば<br>お前が平和への足を引っ張る可能性がある
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★ディナタン★★:…わかっています！<br>なにもできないことくらい！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_030041")

	change_face(Actor002,"Laugh")

	--★★イゾルデ★★:身の程を知っているのね<br>良かったわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:それでも<br>気にしないではいられません！！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_030043")

	change_face(Actor002,"Surprise")

	--★★イゾルデ★★:家族だから？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030045")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:ずっとそばにいてくれた人<br>だからです
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_030046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:無垢で、幼稚さを孕んでいるわね<br>もちろん褒めているのだけれど
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030047")

	change_face(Actor002,"Laugh")

	--★★イゾルデ★★:深情けにならないことを祈るわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_030049")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
