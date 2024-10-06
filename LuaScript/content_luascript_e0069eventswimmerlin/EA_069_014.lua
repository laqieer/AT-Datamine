-- このluaスクリプトは、EA_069_014.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation03","DuelCommonFormation03_h")
Include("content_adv_advsmall_duelcommonformation03","TemplateDuelCommonFormation03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation03,CameraPosDuelCommonFormation03_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation03_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation03,CameraPosDuelCommonFormation03_009)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation03,CameraPosDuelCommonFormation03_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation03,CameraPosDuelCommonFormation03_006)
	InitializeTemplateRandomCameraDuelCommonFormation03()
	InitializeTemplateDuelCommonFormation03()
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
turn_chara(Actor002,17,0)
set_pos(Actor003,{7.06,0.0,3.127})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101016","001","101016001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…やっぱり、駄目
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140001")

	PlayAction(Actor001,"to Annoyed")

	--★★ギネヴィア★★:なんで、どうしてよ<br>このままじゃ…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0050")
-- ▲直接出力

	--★★ランスロット★★:落ち着いてください<br>既に殿下は祭壇での儀式を終えられています
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_069_0140003")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★ランスロット★★:素養は充分にあるのですから<br>焦らず機が熟すのを待って――
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_069_0140004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0018")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:そんなの無理よ！待ってらんない！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140005")


	--★★ギネヴィア★★:あなた最強騎士で先生としても優秀なんでしょ？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140006")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ギネヴィア★★:だったら早く教えてよ<br>バルバロイをまとめてやっつける方法を！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:早くしないと――
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140008")

	change_face(Actor005,"Anger")

	--★★ギネマウア話★★:殿下！
	Talk(Actor005,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140009")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140010")

-- ▼直接出力
CloseTalkWindow()
turn_chara(Actor001,67.708,0.8)
PlayActionDirect(Actor001,"to Wlk")
Appear(Actor003)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{3.436,0,2.526},2.0)
wait_time(0.8)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.2)
setup_small_camera_start(Camera003)
turn_lookat(Actor003,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:お姉ちゃん…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140012")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0018")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ギネマウア★★:これ以上ワガママを言ってはいけません<br>ランスロット先生はお忙しいのです
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140013")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0015")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:ワガママって！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140014")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0025")
-- ▲直接出力

	--★★ギネマウア★★:一生徒が先生に時間外の個人指導を強いるなんて…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140015")


	--★★ギネマウア★★:そんなこと、他の生徒は誰もしていない<br>迷惑だとわかりませんか
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0052")
-- ▲直接出力

	--★★ランスロット★★:いや、俺は特に迷惑だとは
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_069_0140017")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0037")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:先生は少し黙っていてください
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:あ、ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_069_0140019")

-- ▼直接出力
change_face(Actor002,"Normal")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Anger")

	--★★ギネマウア★★:そのうえあなたは自分の不出来で癇癪を起こし<br>付き合ってくれている先生に当たり散らして
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140020")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:王妃という身分を笠に着ていると<br>言われても仕方ない
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140021")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネマウア★★:そんなふうに言われることは<br>あなただって不本意でしょ？
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140022")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0050")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:それは…そうだけど。でも、わたし――
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140023")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★ギネマウア★★:でも、じゃない
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140024")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140025")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0032")
-- ▲直接出力

	--★★ギネヴィア★★:…なにそれ<br>聞いてもくれないの、わたしの話
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140026")

	PlayAction(Actor001,"to Annoyed")
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:わたしだって色々考えて、なのに――
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140027")

-- ▼直接出力
voice_play("VO_101016_sp_0003_1")
-- ▲直接出力

	--★★ギネマウア★★:ギネヴィア
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:…もういい
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140029")


	--★★ギネヴィア★★:わたしのことなんてどうでもいいんだ<br>ならわたしだって、お姉ちゃんなんか知らない
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140030")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0016")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:お姉ちゃんのバカ！！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0140031")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor001,"to Run")
turn_chara(Actor001,8.695,0.4)
wait_time(0.4)
slidemove(Actor001,{3.0,0.0,9.23},1.5)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-27.0,0.8)
wait_time(0.8)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.7)
Hide(Actor001)
wait_time(2.0)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:追いかけないのか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_069_0140033")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor002,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0038")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:ああなったらどのみち<br>しばらく話はできませんから
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140034")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:部屋に帰ってベッドに潜り込んで籠城<br>いつものことです
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140035")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0053")
-- ▲直接出力

	--★★ランスロット★★:…彼女も慣れない環境で心細いのだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_069_0140036")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0049")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:そういって、もう4ヶ月経っているんです
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140037")

	change_face(Actor003,"Sad")

	--★★ギネマウア★★:学園の誰にも心を開かず<br>常に意地と虚勢を張って
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140038")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ギネマウア★★:あの子の気持ちもわかるけど<br>でもこのままじゃ、あの子のためにならない
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140039")

	change_face(Actor003,"Anger")

	--★★ギネマウア★★:だからこそ、私は厳しくいなくては<br>私にはあの子を守る義務があるのですから
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0025")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:<ruby=おとうさま>キャメリアード国王</ruby>に代わって…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0140041")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0034")
-- ▲直接出力

	--★★ランスロット★★:ギネマウア…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_069_0140043")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

Hide(Actor003)
Hide(Actor002)
Appear(Actor004)
setup_small_camera_start()

wait_time(1.5)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★マーリン★★:………
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0140045")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101016","001","101016001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
