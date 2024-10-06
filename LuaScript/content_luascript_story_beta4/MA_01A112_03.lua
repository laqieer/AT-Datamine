-- このluaスクリプトは、MA_01A112_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_03","111013_03_h")
Include("content_adv_advsmall_111013_03","Template111013_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111013_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111013_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111013_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_008)
	InitializeTemplateRandomCamera111013_03()
	InitializeTemplate111013_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
load_image("101030540", "content_still_10103054_image", "101030540_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101044","001","101044001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:スノードン山での戦いに勝利し<br>ルーシャスはついに聖杯を手にした
	Talk(Actor007,"telop","narration","N","MA_01A112_031001")


	--★★テロップ★★:その一方、魔女による侵食は進み、ローマ兵は<br>バルバロイに喰い尽くされようとしていた
	Talk(Actor007,"telop","narration","N","MA_01A112_031002")


	--★★テロップ★★:多くの兵を犠牲にしても目指す<br>ルーシャスの願いを当人以外は誰も知る由もない
	Talk(Actor007,"telop","narration","N","MA_01A112_031003")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:良いピクニックであったな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030002")

	change_face(Actor001,"Normal")

	--★★ルーシャス★★:聖杯、魔女の根源モルガン、そして勝利<br>欲するものはすべて手に入った
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030003")

-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定2")
-- ▲直接出力

	--★★モーロノエー★★:大姉様は私たちがいただくわ<br>食べ尽くすにはもう少しかかるけれど
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","L","MA_01A112_030004")

-- ▼直接出力
 --PlayPartVoice("グリーテン", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★グリーテン★★:聖杯も、我らのものです
	Talk(Actor006,"CHRNAME_SISTERS_3","speech","L","MA_01A112_030005")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME_FAST)
wait_time(FADE_TIME_FAST)
show_image("101030540",0,0,0,true,false)
fadein(FADE_TIME_FAST)
wait_time(FADE_TIME_FAST + 0.5)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定")
-- ▲直接出力

	--★★モーロノエー★★:これは私たちがお預かりします<br>文句はないわね、皇太子殿下？
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","L","MA_01A112_030007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "挨拶")
-- ▲直接出力

	--★★ルーシャス★★:余らローマはバルバロイの手足<br>文句など滅相も
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030008")

	PlayAction(Actor006,"to  Std_Worry")
	change_face(Actor006,"Normal")

	--★★グリーテン★★:いずれにせよ<br>今のままでは聖杯の力を発揮できないけれど
	Talk(Actor006,"CHRNAME_SISTERS_3","speech","L","MA_01A112_030009")


	--★★ルーシャス★★:そのすべを<br>そなたらは知らぬのか？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030010")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME_FAST)
wait_time(FADE_TIME_FAST)
hide_image()
setup_small_camera_start(Camera005)
fadein(FADE_TIME_FAST)
wait_time(FADE_TIME_FAST + 0.5)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "悩む")
-- ▲直接出力

	--★★モーロノエー★★:私たち魔女は元々モルガンから分かたれた者<br>彼女の知識の断片は持ち得ているけれど
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","L","MA_01A112_030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("グリーテン", "肯定2")
-- ▲直接出力

	--★★グリーテン★★:深層の記憶までは<ruby=モルガン>大姉様</ruby>でなければ…<br>それを知るのも時間の問題ですけれどね
	Talk(Actor006,"CHRNAME_SISTERS_3","speech","L","MA_01A112_030012")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor005)
Hide(Actor006)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力

	--★★ルーシャス★★:褒めて遣わすぞ、将軍
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030014")

	PlayAction(Actor003,"to Bow")
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定3")
-- ▲直接出力

	--★★ヴェルナルス★★:…もったいなきお言葉
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","MA_01A112_030015")


	--★★ルーシャス★★:聖杯を獲得し、更にそれを探しに来た騎士どもを<br>復帰困難にまで追い込んだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:余が愛するローマの兵たちも<br>既に大半が喜んでバルバロイに身を捧げた
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030017")


	--★★ルーシャス★★:ブリテン島の東半分はすべてバルバロイの餌場<br>人的資源が限られているログレスに勝ち目はない
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ヴェルナルス★★:…避難民はいかがされます
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","MA_01A112_030019")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "怒り")
-- ▲直接出力

	--★★ルーシャス★★:なんだそれは？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:ロンディニウムにて殉死を拒んだ者…<br>カレドニアで捕らえた一般市民たちは──
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","MA_01A112_030021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "激怒")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:申しておるだろう<br>「なんだそれは」と
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴェルナルス★★:…は
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","MA_01A112_030023")

-- ▼直接出力
 --PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:どうして殺して来てくれなかったの、ラシア
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_030024")


	--★★ラシア★★:…魔女モルガンを制するとともに<br>聖杯を持ち帰ることに全力を尽くしました
	Talk(Actor004,"CHRNAME_RASIA","speech","L","MA_01A112_030025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:そしてこの勝利は、フレンとローラ<br>あなたたち姉妹に捧げるための──
	Talk(Actor004,"CHRNAME_RASIA","speech","L","MA_01A112_030026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:そんなのどうだっていいの<br>どうして妹の仇を殺して来てくれなかったの
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_030027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:すまぬな将軍、下がってくれ<br>余の愛しき小鳥は機嫌が悪いようだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030029")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor003)
Hide(Actor004)
keep_ik_lookat(Actor002,Actor001,"J_Head")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:…ルーシャスくんは聖杯になにを願うの？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_030031")


	--★★ルーシャス★★:さてな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フレン★★:ルーシャスくんはバルバロイに従ってまで<br>なにをしようとしているの？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_030033")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:語ったはずだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030034")


	--★★ルーシャス★★:不眠の軍勢とともに成す<br>民たちの眠れぬ日々からの解放
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030035")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★フレン★★:すべての道が君へと繋がる<br>『ローマによる平和』──
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_030037")

-- ▼直接出力
 --PlayPartVoice("フレン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:バルバロイこそ因縁の始まりでしょう<br>恨みこそすれ、それに平伏して虐殺まで…
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_030039")

	PlayAction(Actor002,"to  Std_No")

	--★★フレン★★:私、ルーシャスくんがわからないまま<br>どこを目指している人なのかわからないまま
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_030040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "否定")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:フレン──<br>さえずりはときに耳障りだよ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030042")


	--★★ルーシャス★★:ひとりの人間が他者に理解し切れるほど<br>単純にできていると思うかね？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030043")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ルーシャス★★:余にしてみれば<br>そなたこそ不合理の塊だよフレン
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030044")


	--★★ルーシャス★★:余の籠に飛び込み、かしましく鳴くだけ<br>短絡的で愚かしくしか見えぬがな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030045")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ルーシャス★★:わからぬよフレン<br>そなたは余になにを求めている？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_030047")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★フレン★★:…私も、君が見えないよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_030048")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101030540", "content_still_10103054_image", "101030540_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101044","001","101044001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
