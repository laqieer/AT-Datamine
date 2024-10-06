-- このluaスクリプトは、MA_01A111_16.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110141_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SleepController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110141_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SleepController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_006)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
-- ▼直接出力
Hide(Actor004)
set_pos(Actor004, {-2.7, 0, 4.6}) 
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005, {4.282,0.725,1.457})
set_rot(Actor005,{0,-90,0})
huton = setup_prop_object(10107002)
set_pos(huton,{3.385,0.05,1.41})
set_rot(huton,{0,270,0})
force_eyesync(Actor005,"Close")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006, {4.282,0.725,-1.6})
set_rot(Actor006,{0,-90,0})
huton2 = setup_prop_object(10107002)
set_pos(huton2,{3.385,0.05,-1.55})
set_rot(huton2,{0,270,0})
force_eyesync(Actor006,"Close")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:まずいことになったね、マァル
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A111_160002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力

	--★★マルディサント★★:これは一大事だぜ、ディーナ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A111_160003")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ど、どうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_160004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor003,"Anger")

	--★★マルディサント★★:おォいオニーサン！こちとら気が立ってンだ！！<br>気安く声かけてんじゃねえぞコラァッ！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","N","MA_01A111_160005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	close_cutin()
	change_face(Actor001,"Sad")

	--★★ノワール★★:ああごめんなマルディサント、大丈夫か？<br>なにか問題でも起きたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_160007")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:心配してくれんのかサンキュー、オニーサン！<br>そっちこそなんの用なんだよオラァッ！！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A111_160008")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:実践の授業でちょっとケガしちゃったから<br>薬でももらおうかと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_160009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:コレ塗ってコレ巻いて安静にしろ！<br>お大事にな！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A111_160010")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ありがとうマルディサント<br>それでなにがあったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_160011")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:兄さん、学園の危機よ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A111_160012")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:知ってのとおり学園は今<br>聖杯取得に向けて色々準備してるの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A111_160013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:私たちも怪我人の治療に全力を注ぐべく<br>薬や医療体制の見直しにかかっていた…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A111_160014")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:た、大変だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_160015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:だけどね、兄さん<br>未曽有の危機が起きてしまったの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A111_160016")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:な、なんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_160017")

-- ▼直接出力
setup_small_camera_start(Camera002)
turn_chara(Actor003,-79.248,0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:モルガン先生がボイコットしたの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A111_160018")

-- ▼直接出力
Appear(Actor004)
se_play("SE_ADV_MA_01B109_11_Door")
wait_time(1.2)
character_in_move_run(Actor004,CharaPos007,1.0,0)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("男子2", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:モルガン先生はいますか！？
	Talk(Actor004,"NPCNAME_0151","speech","N","MA_01A111_160020")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:いねえよ！！なんだ！？<br>急ぎの用っぽいが要件を言えオラァッ！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A111_160021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("男子2", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:訓練で怪我人が…！
	Talk(Actor004,"NPCNAME_0151","speech","N","MA_01A111_160022")

-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:訓練で怪我するほどヤんのは気合があって結構！<br>アタシらがモルガン先生代理だ、今行くよッ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A111_160023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:ごめんね兄さん<br>そういうわけで医療体制の危機なの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A111_160024")


	--★★ディナタン★★:けが、しないでね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A111_160026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10107002)
setup_prop_object_preload(10107002)
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
