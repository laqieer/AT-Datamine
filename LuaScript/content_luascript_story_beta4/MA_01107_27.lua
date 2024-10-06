-- このluaスクリプトは、MA_01107_27.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111091_01","111091_01_h")
Include("content_adv_advsmall_111091_01","Template111091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-25,CharaPos111091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_003)
	Camera002 = SetTemplate("Actor002",0,CharaPos111091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111091_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_001)
	Camera005 = SetTemplate("Actor005",-35,CharaPos111091_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_004)
	Camera006 = SetTemplate("Actor006",-25,CharaPos111091_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_006)
	Camera008 = SetTemplate("Actor008",65,CharaPos111091_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_008)
	InitializeTemplateRandomCamera111091_01()
	InitializeTemplate111091_01()
-- ▼直接出力
set_pos(Actor002,{-0.7,-0.65,7.5})
set_pos(Actor006,{0.4,-0.65,6.5})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008,false)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111091)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","002","101001002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","002","101017002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor007,"to  Std_Talk")
	change_face(Actor007,"Smile")

	--★★皇帝ルーシャス★★:良き踊りを見た
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270002")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★皇帝ルーシャス★★:バルバロイは湖より出で湖に消える…<br>とする文献もあったが、まさか本当とはな
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270003")

	change_face(Actor003,"Surprise")

	--★★ディナタン★★:…そういえば剣の祭壇も<br>湖のそばにあった…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_270004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01107_270006")

-- ▼直接出力
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Worry")
-- ▲直接出力

	--★★皇帝ルーシャス★★:バルバロイの封として伝えられていたが<br>まあ、十中八九間違いないのだろうな
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270007")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あんたは<br>そのために俺をここに…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_270008")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★皇帝ルーシャス★★:眺めさせてもらったよ
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270009")

-- ▼直接出力
PlayActionDirect(Actor007,"to Std_Loop")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★皇帝ルーシャス★★:継承者が湖に近づけばなにか起こらないか<br>魔女が秘密をなにかポロリと語らないかとね
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270010")

	change_face(Actor007,"Normal")

	--★★皇帝ルーシャス★★:敵本陣に肉薄するとなれば<br>最強騎士の護衛も得やすいだろうと思ってな
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270011")

	PlayAction(Actor005,"to Bow")

	--★★ランスロット★★:…自らの足で確かめようという気概<br>感服いたします
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01107_270012")

-- ▼直接出力
setup_small_camera_end()
manager.CloseupUpExclusiveCamera(Actor004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
set_enable_auto_lookat_all(true)
lookat_weight(Actor001,0.7,0.03,0.7,0)
lookat_weight(Actor002,0.6,0.03,0.7,0)
lookat_weight(Actor003,0.7,0.03,0.7,0)
lookat_weight(Actor005,0.7,0.03,0.7,0)
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マルディサント★★:傍観してただけじゃねえか<br>ざけんな
	Talk(Actor004,"CHRNAME_MALADISANT2","speech","L","MA_01107_270013")

-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayActionDirect(Actor003,"to  Std_Surp")
turn_chara(Actor003,-10,0.3)
-- ▲直接出力

	--★★ディナタン★★:マァル～～～ッッ！！<br>すみませんすみませんッッ！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_270014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor006)
PlayActionDirect(Actor006,"to  Std_Talk")
turn_chara(Actor006,5,0.3)
-- ▲直接出力

	--★★トリスタン★★:他者をどれだけ上手に使えるかも<br>上に立つ者に問われる能力のひとつだよ
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_270015")

-- ▼直接出力
set_enable_auto_lookat_all(true)
PlayActionDirect(Actor006,"to Std_Loop")
turn_chara(Actor006,-25,0.5)
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Worry")
-- ▲直接出力

	--★★皇帝ルーシャス★★:ただまあ…この湖にはこれ以上<br>祭壇や封印に関わるものは見当たらないな
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270016")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★皇帝ルーシャス★★:バルバロイも変わらず湧き続ける…<br>…やはり『聖杯』が必要か
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_270018")

-- ▼直接出力
PlayActionDirect(Actor007,"to Std_Loop")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★皇帝ルーシャス★★:余もまだすべての情報をつかんだわけではない<br>…あくまで憶測にすぎんが──
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270019")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Talk")
-- ▲直接出力

	--★★皇帝ルーシャス★★:手にした者の願いを叶えてくれる奇跡の器<br>それが聖杯
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270021")


	--★★皇帝ルーシャス★★:バルバロイを根絶する鍵とされる人間<br>継承者
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270023")


	--★★皇帝ルーシャス★★:継承者を導く最初の武器<br>カリバーン、もといティルフィング
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270024")


	--★★皇帝ルーシャス★★:そして人間を聖杯へと導く存在<br>それが妖精
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270025")

-- ▼直接出力
PlayActionDirect(Actor007,"to Std_Loop")
-- ▲直接出力

	--★★皇帝ルーシャス★★:そのすべてを学園は求めている<br>僅かに遺された伝承をもとにな
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Worry")

	--★★皇帝ルーシャス★★:…つまりこれらを一本の線に繋げることで<br>バルバロイの根絶が成るのではと睨んでいる
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270027")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor005)
lookat_weight(Actor008,0.8,0.03,0.7,0)
-- ▲直接出力

	--★★ランスロット★★:…
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01107_270029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008,true)
set_common_look_at(Actor007,Actor008)
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Talk")
turn_chara(Actor007,150,0.5)
-- ▲直接出力

	--★★皇帝ルーシャス★★:さて。ヴェルナルスよ<br>そろそろ武器の量産が大詰めの頃合いかな
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270030")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)

	--★★ヴェルナルス大将軍★★:おそらくは
	Talk(Actor008,"CHRNAME_VERNARTH","speech","L","MA_01107_270031")

	PlayAction(Actor006,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat(Actor007,true)
set_enable_auto_lookat(Actor008,false)
lookat_delay_weight_reset(Actor008,1)
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★トリスタン★★:武器の量産とは？
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01107_270032")

-- ▼直接出力
set_enable_auto_lookat(Actor007,false)
PlayActionDirect(Actor007,"to Std_Loop")
turn_chara(Actor007,125,0.5)
-- ▲直接出力

	--★★皇帝ルーシャス★★:カレドニアと戦うには武器がいるだろう<br>ローマの兵士となれば必要な数は膨大だ
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270033")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)

	--★★皇帝ルーシャス★★:なぜわざわざ<br>キャメリアードの鉱山を取り戻したと思っている
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:島国の小競り合いには興味がないって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_270035")


	--★★皇帝ルーシャス★★:我がローマがバルバロイとどれだけ戦えるか…<br>という戦争には大いに興味がある
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Appl")
	open_cutin(1,2)
	on_cutin(1,Actor007,"Smile")

	--★★皇帝ルーシャス★★:ゲームクリアおめでとう<br>サンキューフォープレイング
	Talk(Actor007,"CHRNAME_LUCIUS","speech","N","MA_01107_270039")

	close_cutin()
	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★ノワール★★:…ありがとう、ございます…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_270040")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★皇帝ルーシャス★★:ローマの軍備が整うまで今しばらくかかる<br>それまで貴様らは母の傍にでもいてやるがいい
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270041")


	--★★ディナタン★★:え…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_270042")

-- ▼直接出力
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Worry")
-- ▲直接出力

	--★★皇帝ルーシャス★★:ここはバルバロイの発生源なのだろう？<br>しばらくすればまた騒がしくなる。今のうちだ
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270043")


	--★★皇帝ルーシャス★★:…まあ、いずれその静寂を未来永劫取り戻すのが<br>継承者の役目だろうからな、精々励め
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270044")

-- ▼直接出力
setup_small_camera_start(Camera007)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor007,"to Std_Loop")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★皇帝ルーシャス★★:母君に良き眠りを
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01107_270046")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + 0.2)
-- ▲直接出力

	--★★テロップ★★:ルーシャルの要望を受けて<br>久々に故郷を訪れたノワールとディナタン
	Talk(Actor009,"telop","narration","N","MA_01107_271001")


	--★★テロップ★★:母の墓参りをしようとするが<br>亡き母の眠りを妨げるように魔女が巣食っていた
	Talk(Actor009,"telop","narration","N","MA_01107_271002")


	--★★テロップ★★:魔女に戦いを挑むノワールとディナタンは<br>ランスロットたちの助力もあり、これを退ける
	Talk(Actor009,"telop","narration","N","MA_01107_271003")


	--★★テロップ★★:その後、ゲームをクリアしたノワールたちに<br>ルーシャスは改めて協力を約束
	Talk(Actor009,"telop","narration","N","MA_01107_271004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:ノワールは継承者の使命を果たすことを<br>母の墓に誓い、帰路についたのだった
	Talk(Actor009,"telop","narration","N","MA_01107_271005")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(111091)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","002","101001002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","002","101017002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
