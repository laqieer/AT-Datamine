-- このluaスクリプトは、MA_01104_901.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
set_pos(Actor003,{2.718, 0, 0.321})
set_pos(Actor004,{1.658, 0, -1.252})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401035","001","401035001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
DontChangeRandomCamera(true)
on_camera(Camera002)
-- ▲直接出力

	--★★ケイ★★:ノワール、待ちたまえ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010002")


	--★★ケイ★★:貴公は試験を突破してみせた<br>一応はおめでとうと言っておこう
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010003")


	--★★ケイ★★:私としては本意ではないが<br>一応は貴公を円卓の騎士として迎え入れる
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010004")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Anger")

	--★★ケイ★★:しかし、なんといっても貴公は敵国の出身だ<br>まずは我が国の騎士としての心構えを…
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010005")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Run")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Run")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor003, 1.293 , 0 ,0.296 ,0.6)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor004, 0.804, 0, -0.509 ,0.6)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★キャメロット軍兵士_上位★★:ケイ様！市街地からほど近い場所で<br>バルバロイが確認されたとのこと！
	Talk(Actor003,"NPCNAME_0304","speech","L","MA_01104_9010006")


	--★★キャメロット軍兵士_上位★★:憲兵団、出動いたします！
	Talk(Actor003,"NPCNAME_0304","speech","L","MA_01104_9010007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ケイ★★:わかったよろしく頼む
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:まったく、いつもいつも突然やってくるよねえ
	Talk(Actor004,"NPCNAME_0305","speech","L","MA_01104_9010009")


	--★★キャメロット軍兵士_上位★★:「これから行きますよ」なんて言ってくれるバルバロイはいないだろ！
	Talk(Actor003,"NPCNAME_0304","speech","L","MA_01104_9010010")

	PlayAction(Actor004,"to  Std_Worry")

	--★★キャメロット軍兵士_下位★★:それはそうだけどさ～どうする、もう因枢分解して行っちゃう？
	Talk(Actor004,"NPCNAME_0305","speech","L","MA_01104_9010011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★キャメロット軍兵士_上位★★:街の門を出たらでいいだろほら、急ぐぞ！
	Talk(Actor003,"NPCNAME_0304","speech","L","MA_01104_9010012")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED + FADE_TIME)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:彼らは？憲兵団とか言ってたけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9010013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:市民をバルバロイから守ることを任務とする兵士たちのことだ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010014")


	--★★ケイ★★:彼らはこの学園で学びゲシュタルト・シフトを果たした…
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ケイ★★:言ってみれば貴公の先輩たちだな
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010016")


	--★★ケイ★★:卒業後、ログレスの軍属となりこの街や付近の村々、同盟国などに駐在している
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:なるほどそんな組織がログレスにはあるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9010018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なあ、俺も憲兵団に入ることはできるかな？街の人を守るというなら、協力したい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9010019")

	change_face(Actor002,"Surprise")

	--★★ケイ★★:なに？
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010020")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ケイ★★:憲兵団に入るためにはゲシュタルト・シフトの儀式を…
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010021")


	--★★ケイ★★:そうか、貴公はすでに済ませているのか
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:我が王の意向で学生のうちは軍属にはできぬため正規入隊というわけにはいかないが
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010023")


	--★★ケイ★★:見習いというかたちでなら構わないだろうバルバロイと戦える者が多いに越したことはない
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010024")

	change_face(Actor002,"Anger")

	--★★ケイ★★:…ただし憲兵団の任務は常に死と隣り合わせになるが？
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:覚悟の上だ俺はもともと傭兵だしな、そんなのは慣れてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9010026")

	change_face(Actor002,"Normal")

	--★★ケイ★★:ふむであれば市街の酒場に行ってみるといい
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010027")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ケイ★★:偵察隊からのバルバロイ出没情報の収集と憲兵団への出動要請は
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010028")


	--★★ケイ★★:あそこにいる情報屋が一任されている
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:市街の酒場？なんだってそんな場所にいるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9010030")


	--★★ケイ★★:なにぶん人手不足なものでな
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9010031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった行ってみるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9010032")

-- ▼直接出力
reserve_next_script("追加メイン/共通/04月12日/追加ストーリーADV_1")
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
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401035","001","401035001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
