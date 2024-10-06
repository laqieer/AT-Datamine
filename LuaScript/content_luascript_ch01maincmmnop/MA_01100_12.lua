-- このluaスクリプトは、MA_01100_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	Camera002 = SetTemplate("Actor002",-200,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_004)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
ShowGlobalMenuButton(false)
set_common_look_at(Actor001,Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-0.88,0.128,45.66})
set_common_look_at(Actor002,Actor001)
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor001)
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
set_pos(Actor004,{0.003, 0.128, 50.14,10.2})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor006,Actor001)
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor001,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor005,Actor001,0)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor005,Actor001)
-- ▲直接出力
-- ▼直接出力
CameraEx1 = set_camera({-2.68, 21.05, 22.78,   340.0788, 6.64692, 359.7292,   30.35})
-- ▲直接出力
-- ▼直接出力
 --白背景読込
load_image("101010150", "content_still_10101015_image", "101010150_StillImage") 
show_image("101010150", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","003","101012003","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	Actor008 = InitializeCharacter_2DOnly("101021","003","101021003")
	Actor009 = InitializeCharacter_2DOnly("101012","003","101012003")
	Actor010 = InitializeCharacter_2DOnly("101015","004","101015004")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
on_camera(CameraEx1)
se_play("SE_ADV_MA_01C111_20_Bell")
hide_image(7.0)
slidemove2(CameraEx1,-4.1, 1.5, 11.2,9.0,3)
turn(CameraEx1,{357.785, 6.56448, 359.7451},9.0)
wait_time(3.0)
open_speech_window("CHRNAME_NAMELES",Actor005,nil)
message_nowait("MA_01100_120002")
wait_time(4.0)
close_speech_window()
wait_time(2.0)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Smile")

	--★★アーサー★★:ログレス王国<br>『キャメロット騎士学術院』へ！
	Talk(Actor005,"CHRNAME_NAMELES","speech","L","MA_01100_120004")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アーサー★★:誉れ高き最強騎士<br>ランスロットの推薦と──
	Talk(Actor005,"CHRNAME_NAMELES","speech","L","MA_01100_120006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
--アーサー,CHRNAME_ARTHUR @名前変更
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:ログレス国王にして円卓の騎士<br>アーサーの名において──
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120007")

-- ▼直接出力
OpenFirstAppearance(Actor010)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！？<br>アーサー、王………！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")
	change_face(Actor005,"Smile")

	--★★アーサー★★:ノワールに<br>新たな円卓の騎士としての座を与える！
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120009")


	--★★ノワール★★:え、円卓の騎士に──…俺が…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120010")


	--★★ケイ★★:…やはり軽率過ぎると思うがね
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01100_120011")

	change_face(Actor006,"Sad")

	--★★ケイ★★:お転婆王妃を救った礼に円卓の空席を与える？<br>円卓の騎士を狙ってきた者を？
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01100_120012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アーサー★★:座すべき者は全てに平等<br>それが円卓を囲む騎士たちの精神だ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120013")

	PlayAction(Actor002,"to Greet_one")

	--★★ギネヴィア★★:ということで、はじめまして
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_120015")


	--★★ギネヴィア★★:わたしがログレス国の真似事王妃<br>ギネヴィア殿下でございます
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_120016")


	--★★ノワール★★:…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:王妃様らしからず、ご無礼を
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_120019")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:そしてここが武器を研ぐ学び舎<br>対バルバロイ唯一の砦だ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120020")


	--★★ノワール★★:武器を、研ぐ………？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★アーサー★★:きっかけは<br>錆びついた劔の軋み
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120022")

	change_face(Actor005,"Sad")

	--★★アーサー★★:バルバロイが現れたのは数十年前<br>このブリテン島に突如として湧き始めた
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120024")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★アーサー★★:なんらかの封が<br>緩みかけているようにな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120025")


	--★★アーサー★★:その姿を見た者は喰われ、生き延びた者は稀<br>悪魔や怪異だとも噂されるが現実の存在だ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:捕食者が着席するような卓を与えはしない<br>それがこの学園の役目
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_120027")


	--★★ランスロット★★:そして円卓の騎士は──
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01100_120029")

	change_face(Actor001,"Normal")

	--★★ノワール★★:「世界平和の願いを叶える聖杯を探し求め<br>その聖杯へ導く妖精を守る騎士」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:…そうだ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01100_120031")

	change_face(Actor006,"Normal")

	--★★ケイ★★:歴史に混乱が訪れると突如顕現し<br>奇跡を起こすという杯──『聖杯』
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01100_120032")

-- ▼直接出力
set_common_look_at(Actor002,Actor005)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Sad02")

	--★★ケイ★★:…『妖精殺し』の息子が<br>聖杯探求の円卓の騎士、とはなんとも皮肉だが
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01100_120033")

	change_face(Actor005,"Normal")

	--★★アーサー★★:ケイ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:『妖精殺し』って…なによ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_120036")


	--★★ケイ★★:これは失礼、口が滑りました
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01100_120037")


	--★★ノワール★★:ランスロット──…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120038")

-- ▼直接出力
setup_small_camera_start()
set_common_look_at(Actor002,Actor001)
-- ▲直接出力

	--★★ノワール★★:母さんは…父さんの帰りを待っていた<br>ずっと、ずっと待っていたんだ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120040")

	change_face(Actor001,"Sad")

	--★★ノワール★★:あんたの口から<br>本当のことが聞きたくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120041")


	--★★ノワール★★:家族で卓を囲める<br>それだけの日常に帰りたくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor003)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★ノワール★★:あんたを追って<br>ここまで来たんだ…！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120043")


	--★★ランスロット★★:ならば<br>置いては行かない
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01100_120044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:応えろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120045")


	--★★ランスロット★★:学園に入れば<br>お前の求める『本当』がわかる
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01100_120046")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…なにを、言ってるんだ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120049")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:お前が、家族とともに<br>帰るための場所となることを願う
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120050")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力

	--★★ノワール★★:家族…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120051")

-- ▼直接出力
se_play("SE_ADV_MA_01104_20_DoorOpen")
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
--ディナタン,CHRNAME_DINATAN @名前変更
-- ▲直接出力

	--★★ディナタン声★★:兄さん！！
	Talk(Actor009,"CHRNAME_NAMELES","speech","N","MA_01100_120053")

-- ▼直接出力
CloseTalkWindow()
turn_chara(Actor001,-40,0)
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001, 0.4, 0.08, 0.7, 0.6)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head", 0.7)
--ディナタン入場
IN_RUN(Actor004,{CharaPos110071_04_005[1],CharaPos110071_04_005[2],CharaPos110071_04_005[3],-171.5})
set_enable_auto_lookat(Actor004,false)
lookat_weight(Actor004, 0.6, 0.08, 0.8, 0.6)
keep_delay_ik_lookat(Actor004,Actor001, "J_Head", 0.5)
change_face(Actor004,"Sad")

-- ▲直接出力

	--★★ノワール★★:ディナタン！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120055")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタン…！怪我は…？<br>無事だったのか！？良かった、生きてて…！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120057")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Sad")

	--★★ディナタン★★:ごめんなさい兄さん…！<br>私、気づいたらここに運び込まれていて…
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01100_120058")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ランスロットが彼女を安全な場所に<br>置いてくれていたらしいケド？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_120059")

	change_face(Actor005,"Smile")

	--★★アーサー★★:妹君を保護し送り届けるべく<br>兄君を戦場に置き去りにしたそうじゃないか！
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120061")

-- ▼直接出力
setup_small_camera_end(Camera003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor004,false)
set_common_look_at(Actor004,Actor003)
set_enable_auto_lookat(Actor005,true)
set_enable_auto_lookat(Actor003,true)
set_enable_auto_lookat(Actor006,true)
set_enable_auto_lookat(Actor002,true)
SkipOffsetCamera(Camera003)
turn_chara(Actor001,-65,0)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ランスロット★★:兄より妹の方が有望そうだろう？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01100_120063")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:は、ぁ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120064")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera004)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,CharaPos110071_04_005[4],0.5)
wait_time(0.5)
PlayActionDirect(Actor004,"to Std_Loop")
lookat_weight(Actor004, 0.6, 0.08, 0.8, 0.6)
keep_delay_ik_lookat(Actor004,Actor003, "J_Head", 0.5)
SkipOffsetCamera(Camera004)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ディナタン★★:ランス兄ちゃん…？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01100_120065")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:あら、こちらもお知り合い？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_120066")

-- ▼直接出力
set_enable_auto_lookat(Actor004,true)
lookat_weight_default(Actor004)
-- ▲直接出力

	--★★ランスロット★★:だが、このノワールも<br>俺ごときには負けないらしい
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01100_120068")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:最強騎士の推薦は心強いな！！
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120070")


	--★★ノワール★★:どうしてだ、ランスロット…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120071")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ランスロット★★:お前の武器を見つけるんだ、ノワール
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01100_120072")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ランスロット★★:円卓の騎士になるんだろう？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01100_120074")


	--★★ブルーノ★★:「ノワールもすぐに追いつくさ」
	Talk(Actor008,"CHRNAME_BRUNO","simple","N","MA_01100_120076")


	--★★ブルーノ★★:「ふたり並んだ姿が見たいな」
	Talk(Actor008,"CHRNAME_BRUNO","simple","N","MA_01100_120077")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:「待っていた」んだ。ずっと
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01100_120079")


	--★★テロップ★★:ようやく見つけた絆のほつれ
	Talk(Actor007,"telop","narration","N","MA_01100_120081")

	change_face(Actor005,"Normal")

	--★★アーサー★★:進路は決まったか
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01100_120083")


	--★★テロップ★★:憧れが幻想だったとしたら<br>模した理想はどうすればいい
	Talk(Actor007,"telop","narration","N","MA_01100_120085")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight_reset(Actor001,0.6)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120087")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:思い出したよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_120089")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","003","101012003","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_2DOnly_Preload("101021","003","101021003")
	InitializeCharacter_2DOnly_Preload("101012","003","101012003")
	InitializeCharacter_2DOnly_Preload("101015","004","101015004")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
