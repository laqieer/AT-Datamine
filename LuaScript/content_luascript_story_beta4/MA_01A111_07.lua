-- このluaスクリプトは、MA_01A111_07.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114091_01","114091_01_h")
Include("content_adv_advsmall_114091_01","Template114091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114091_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_004)
	InitializeTemplateRandomCamera114091_01()
	InitializeTemplate114091_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114091)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
turn_chara(Actor001, 110, 0)
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:大輪の花が似合うと思うのよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_070002")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★エレイン★★:え？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_070003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")

	--★★ギネヴィア★★:大女優、終演のお祝いには
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_070004")

	change_face(Actor002,"Smile")

	--★★エレイン★★:…どのお花をいただけるんですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_070006")

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:端から端までぜんぶ、ぜーんぶ！<br>わたしの貧しい発想から出た贅沢な贈り物よ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_070007")


	--★★エレイン★★:…見慣れた景色なんですよ<br>実は
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_070008")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:えぇえっっ！？そーなの？<br>ここ結構穴場かと思ってたのに！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_070009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★エレイン★★:だけど「全部私のもの」だと言われてしまうと<br>その気になってしまいます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_070010")


	--★★エレイン★★:素敵だなって思う人の言葉が<br>いつも私の景色を変えてくれる
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_070011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★エレイン★★:その感じ…ちょっと痛快なんですよ<br>ありがとうございます、ギネヴィア様…！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_070012")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:手紙に書いた言葉で会話してた子だったのにさ<br>いつの間にか──
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_070013")


	--★★ギネヴィア★★:書かれた言葉、台本の台詞すら<br>自分のものにするようになってた
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_070014")


	--★★ギネヴィア★★:あなた自身から出ている言葉に聞こえた<br>エレインがその人になっているような感覚
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_070015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:胸が熱くなったの、すっごく
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_070016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:関わってくださる方が誰かひとりでも欠けたら<br>私は舞台に立てなかったと思います。それに──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_070017")


	--★★エレイン★★:舞台に上がるのが怖くなった時に思い出したのは<br>ギネヴィア様のことです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_070018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:わ、わたしがなに？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_070019")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★エレイン★★:あの日の演説が<br>憧れの瞬間だったから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_070020")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114091)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
